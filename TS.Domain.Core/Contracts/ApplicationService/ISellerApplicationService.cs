﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ISellerApplicationService
    {
        Task<Seller> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Seller>> GetAll(CancellationToken cancellationToken);
        Task Create(string sellername, CancellationToken cancellationToken);
        Task Update(Seller entity, CancellationToken cancellationToken);
        Task Active(int sellerId, CancellationToken cancellationToken);
        Task DeActive(int sellerId, CancellationToken cancellationToken);
    }
}