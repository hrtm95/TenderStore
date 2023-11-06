using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _orderService;
        public OrderService(IOrderService orderService)
        {
            _orderService = orderService;  
        }

        public Task Active(int orderId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(OrderDto orderDto, CancellationToken cancellationToken)
        {
           await _orderService.Create(orderDto, cancellationToken).ConfigureAwait(false);
        }

        public Task DeActive(int orderId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAll(CancellationToken cancellationToken)
        => await _orderService.GetAll(cancellationToken).ConfigureAwait(false);

        public Task<Order> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderDto orderDto, CancellationToken cancellationToken)
        {
            await _orderService.Update(orderDto, cancellationToken).ConfigureAwait(false);
        }

    }
}
