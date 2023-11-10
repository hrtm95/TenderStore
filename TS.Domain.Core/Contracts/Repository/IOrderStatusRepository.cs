using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IOrderStatusRepository
    {
        Task<List<OrderStatus>> GetAll(CancellationToken cancellationToken);
        Task Update(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task Create(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
