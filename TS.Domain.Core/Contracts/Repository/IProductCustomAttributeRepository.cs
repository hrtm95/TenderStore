﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IProductCustomAttributeRepository
    {
        Task<List<ProductCustomAttribute>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
