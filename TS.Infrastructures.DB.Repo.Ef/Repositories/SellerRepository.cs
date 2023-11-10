using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class SellerRepository : ISellerRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public SellerRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Seller>(sellerDto);
            await _db.Sellers.AddAsync(record);
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
            var order = await _db.Sellers
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Seller>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Sellers
              .AsNoTracking()
              .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<Seller>(_db.Set<Seller>())
                 .Where(x => x.Id == sellerDto.Id).FirstOrDefaultAsync();
            _mapper.Map(sellerDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int sellerId, CancellationToken cancellationToken)
        {
            var record = await _db.Sellers
               .Where(x => x.Id == sellerId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int sellerId, CancellationToken cancellationToken)
        {
            var record = await _db.Orders
               .Where(x => x.Id == sellerId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
