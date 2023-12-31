﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IMedalRepository
    {
        Task<List<Medal>> GetAll(CancellationToken cancellationToken);
        Task Update(MedalDto medalDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(MedalDto medalDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
