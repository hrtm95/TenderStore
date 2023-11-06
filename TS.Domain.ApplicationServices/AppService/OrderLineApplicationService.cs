﻿using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class OrderLineApplicationService : IOrderLineApplicationService
    {
        private readonly IOrderLineApplicationService _orderLineService;
        public OrderLineApplicationService(IOrderLineApplicationService orderLineService)
        {
            _orderLineService = orderLineService;
        }

        public Task Active(int orderLineId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(OrderLineDto orderLineDto, CancellationToken cancellationToken)
        {
            await _orderLineService.Create(orderLineDto, cancellationToken);
        }

        public Task DeActive(int orderLineId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderLine>> GetAll(CancellationToken cancellationToken)
        => await _orderLineService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(OrderLineDto orderLineDto, CancellationToken cancellationToken)
        {
            await _orderLineService.Update(orderLineDto, cancellationToken);
        }
    }
}
