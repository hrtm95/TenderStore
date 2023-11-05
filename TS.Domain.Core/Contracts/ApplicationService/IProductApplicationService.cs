using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IProductApplicationService
    {
        Task<Product> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Product>> GetAll(CancellationToken cancellationToken);
        Task Create(ProductDto entity, CancellationToken cancellationToken);
        Task Update(ProductDto entity, CancellationToken cancellationToken);
        Task Active(int productId, CancellationToken cancellationToken);
        Task DeActive(int productId, CancellationToken cancellationToken);
    }
}
