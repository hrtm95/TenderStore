﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IOrderLineRepository
    {
        Task<List<OrderLine>> GetAll(CancellationToken cancellationToken);
        Task Update(OrderLineDto orderLineDto, CancellationToken cancellationToken);
        Task Create(OrderLineDto orderLineDto , CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
