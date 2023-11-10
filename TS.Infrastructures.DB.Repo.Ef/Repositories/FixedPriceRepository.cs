using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class FixedPriceRepository : IFixedPriceRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public FixedPriceRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<FixedPrice>(fixedPriceDto);
            await _db.FixedPrices.AddAsync(record);
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
            var order = await _db.FixedPrices
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<FixedPrice>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.FixedPrices
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<FixedPrice>(_db.Set<FixedPrice>())
                .Where(x => x.Id == fixedPriceDto.Id).FirstOrDefaultAsync();
            _mapper.Map(fixedPriceDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int FixedPriceId, CancellationToken cancellationToken)
        {
            var record = await _db.FixedPrices
               .Where(x => x.Id == FixedPriceId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int FixedPriceId, CancellationToken cancellationToken)
        {
            var record = await _db.FixedPrices
               .Where(x => x.Id == FixedPriceId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
