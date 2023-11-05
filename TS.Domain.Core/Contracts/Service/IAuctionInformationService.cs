﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IAuctionInformationService 
    {
        Task<List<AuctionInformation>> GetAll(CancellationToken cancellationToken);
        Task Update(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
