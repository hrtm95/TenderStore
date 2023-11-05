using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IOrderStatusApplicationService
    {
        Task<List<OrderStatus>> GetAll(CancellationToken cancellationToken);
        Task Update(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task Create(OrderStatusDto orderStatusDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int orderStatusId, CancellationToken cancellationToken);
        Task DeActive(int orderStatusId, CancellationToken cancellationToken);
    }
}
