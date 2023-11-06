using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IOrderService
    {
        Task<Order> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Order>> GetAll(CancellationToken cancellationToken);
        Task Create(OrderDto entity, CancellationToken cancellationToken);
        Task Update(OrderDto entity, CancellationToken cancellationToken);
        Task Active(int orderId, CancellationToken cancellationToken);
        Task DeActive(int orderId, CancellationToken cancellationToken);
    }
}
