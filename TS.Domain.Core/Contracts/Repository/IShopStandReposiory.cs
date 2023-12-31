﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IShopStandReposiory
    {
        Task<List<ShopStand>> GetAll(CancellationToken cancellationToken);
        Task Update(ShopStandDto boothDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Active(int Id, CancellationToken cancellationToken);
        Task DeActive(int Id, CancellationToken cancellationToken);
        Task Create(ShopStandDto boothDto, CancellationToken cancellationToken);
        Task<ShopStand> GetBy(int Id, CancellationToken cancellationToken);
    }
}
