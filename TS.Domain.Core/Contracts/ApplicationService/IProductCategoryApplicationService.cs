using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IProductCategoryApplicationService
    {
        Task<List<ProductCategory>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken);
        Task Create(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int productCategoryId, CancellationToken cancellationToken);
        Task DeActive(int productCategoryId, CancellationToken cancellationToken);
    }
}
