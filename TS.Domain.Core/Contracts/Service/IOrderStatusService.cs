using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IOrderStatusService
    {
        Task<List<OrderStatus>> GetAll(CancellationToken cancellationToken);
        Task Update(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
