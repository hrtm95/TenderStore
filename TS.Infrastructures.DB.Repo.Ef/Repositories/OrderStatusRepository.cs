using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public OrderStatusRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(OrderStatusDto orderStatusDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<OrderStatus>(orderStatusDto);
            await _db.OrderStatus.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<OrderStatus>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.OrderStatus
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderStatusDto orderStatusDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<OrderStatus>(_db.Set<OrderStatus>())
                .Where(x => x.Id == orderStatusDto.Id).FirstOrDefaultAsync();
            _mapper.Map(orderStatusDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
