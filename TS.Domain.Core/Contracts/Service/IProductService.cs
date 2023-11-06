using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IProductService
    {
        Task<Product> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Product>> GetAll(CancellationToken cancellationToken);
        Task Create(ProductDto entity, CancellationToken cancellationToken);
        Task Update(ProductDto entity, CancellationToken cancellationToken);
        Task Active(int productId, CancellationToken cancellationToken);
        Task DeActive(int productId, CancellationToken cancellationToken);
    }
}
