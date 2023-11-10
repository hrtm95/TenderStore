using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class OrderLineRepository : IOrderLineRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public OrderLineRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(OrderLineDto orderLineDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<OrderLine>(orderLineDto);
            await _db.OrderLines.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<OrderLine>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.OrderLines
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderLineDto orderLineDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<OrderLine>(_db.Set<OrderLine>())
                .Where(x => x.Id == orderLineDto.Id).FirstOrDefaultAsync();
            _mapper.Map(orderLineDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
