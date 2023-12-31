﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IAuctionRepository
    {
        Task<List<AuctionPrice>> GetAll(CancellationToken cancellationToken);
        Task Update(AuctionPriceDto auctionDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(AuctionPriceDto auctionDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
