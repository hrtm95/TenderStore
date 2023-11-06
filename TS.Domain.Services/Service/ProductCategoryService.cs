using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoryService(IProductCategoryService productCategoryService)
        {
            IProductCategoryService _productCategoryService;
        }

        public Task Active(int productCategoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken)
        {
            await _productCategoryService.Create(productCategoryDto, cancellationToken);
        }

        public Task DeActive(int productCategoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductCategory>> GetAll(CancellationToken cancellationToken)
        => await _productCategoryService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken)
        {
            await _productCategoryService.Update(productCategoryDto, cancellationToken);
        }
    }
}
