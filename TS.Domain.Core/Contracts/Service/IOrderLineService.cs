using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IOrderLineService
    {
        Task<List<OrderLine>> GetAll(CancellationToken cancellationToken);
        Task Update(OrderLineDto orderLineDto, CancellationToken cancellationToken);
        Task Create(OrderLineDto orderLineDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int orderLineId, CancellationToken cancellationToken);
        Task DeActive(int orderLineId, CancellationToken cancellationToken);
    }
}
