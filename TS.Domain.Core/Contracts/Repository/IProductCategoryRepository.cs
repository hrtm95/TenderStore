using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCategory>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
