using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;
        public AuctionRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task Create(AuctionPriceDto auctionDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<AuctionPrice>(auctionDto);
            await _db.AuctionPrices.AddAsync(record);
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
            var order = await _db.AuctionPrices
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<AuctionPrice>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.AuctionPrices
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(AuctionPriceDto auctionDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<AuctionPrice>(_db.Set<AuctionPrice>())
                .Where(x => x.Id == auctionDto.Id).FirstOrDefaultAsync();
            _mapper.Map(auctionDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int AuctionId, CancellationToken cancellationToken)
        {
            var record = await _db.AuctionPrices
               .Where(x => x.Id == AuctionId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int AuctionsId, CancellationToken cancellationToken)
        {
            var record = await _db.AuctionPrices
               .Where(x => x.Id == AuctionsId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
