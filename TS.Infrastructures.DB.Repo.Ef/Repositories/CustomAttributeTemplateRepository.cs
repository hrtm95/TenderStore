using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class CustomAttributeTemplateRepository : ICustomAttributeTemplateRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;
        public CustomAttributeTemplateRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<CustomAttribute>(customAttributeTemplateDto);
            await _db.CustomAttributes.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var order = await _db.CustomAttributes
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<CustomAttribute>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.CustomAttributes
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<CustomAttribute>(_db.Set<CustomAttribute>())
                .Where(x => x.Id == customAttributeTemplateDto.Id).FirstOrDefaultAsync();
            _mapper.Map(customAttributeTemplateDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int CustomAttributeId, CancellationToken cancellationToken)
        {
            var record = await _db.CustomAttributes
               .Where(x => x.Id == CustomAttributeId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int CustomAttributeId, CancellationToken cancellationToken)
        {
            var record = await _db.CustomAttributes
               .Where(x => x.Id == CustomAttributeId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
