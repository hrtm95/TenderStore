using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class OrderStatusApplicationService : IOrderStatusApplicationService
    {
        private readonly IOrderStatusApplicationService _orderStatusService;
        public OrderStatusApplicationService(IOrderStatusApplicationService orderStatusService)
        {
            _orderStatusService = orderStatusService;
        }

        public Task Active(int orderStatusId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(OrderStatusDto orderStatusDto, CancellationToken cancellationToken)
        {
            await _orderStatusService.Create(orderStatusDto, cancellationToken);   
        }

        public Task DeActive(int orderStatusId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderStatus>> GetAll(CancellationToken cancellationToken)
        => await _orderStatusService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderStatusDto orderStatusDto, CancellationToken cancellationToken)
        {
            await _orderStatusService.Update(orderStatusDto, cancellationToken);
        }
    }
}
