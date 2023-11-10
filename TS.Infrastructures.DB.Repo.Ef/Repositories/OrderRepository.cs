using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public OrderRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(OrderDto orderDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Order>(orderDto);
            await _db.Orders.AddAsync(record);
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
            var order = await _db.Orders
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Order>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Orders
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderDto orderDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<Order>(_db.Set<Order>())
                .Where(x => x.Id == orderDto.Id).FirstOrDefaultAsync();
            _mapper.Map(orderDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int OrderId, CancellationToken cancellationToken)
        {
            var record = await _db.Orders
               .Where(x => x.Id == OrderId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int OrderId, CancellationToken cancellationToken)
        {
            var record = await _db.Orders
               .Where(x => x.Id == OrderId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
