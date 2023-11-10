using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class ProductCustomAttributeRepository : IProductCustomAttributeRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public ProductCustomAttributeRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task Create(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<ProductCustomAttribute>(productCustomAttributeDto);
            await _db.ProductCustomAttributes.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            };
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var order = await _db.ProductCustomAttributes
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<ProductCustomAttribute>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.ProductCustomAttributes
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<ProductCustomAttribute>(_db.Set<ProductCustomAttribute>())
                .Where(x => x.Id == productCustomAttributeDto.Id).FirstOrDefaultAsync();
            _mapper.Map(productCustomAttributeDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int ProductCustomAttributesId, CancellationToken cancellationToken)
        {
            var record = await _db.ProductCustomAttributes
               .Where(x => x.Id == ProductCustomAttributesId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int ProductCustomAttributesId, CancellationToken cancellationToken)
        {
            var record = await _db.ProductCustomAttributes
               .Where(x => x.Id == ProductCustomAttributesId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
