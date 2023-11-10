using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Efs
{
    public class MedalRepository : IMedalRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public MedalRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(MedalDto medalDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Medal>(medalDto);
            await _db.Medals.AddAsync(record);
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
            var order = await _db.Medals
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Medal>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Medals
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MedalDto medalDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<Medal>(_db.Set<Medal>())
                .Where(x => x.Id == medalDto.Id).FirstOrDefaultAsync();
            _mapper.Map(medalDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int medalId, CancellationToken cancellationToken)
        {
            var record = await _db.Medals
               .Where(x => x.Id == medalId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int medalId, CancellationToken cancellationToken)
        {
            var record = await _db.Medals
               .Where(x => x.Id == medalId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
