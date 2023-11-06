using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        public ProductService(IProductService productService)
        {
                _productService = productService;
        }

        public Task Active(int productId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ProductDto productDto, CancellationToken cancellationToken)
        {
            await _productService.Create(productDto, cancellationToken);
        }

        public Task DeActive(int productId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        => await _productService.GetAll(cancellationToken);

        public Task<Product> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductDto productDto, CancellationToken cancellationToken)
        {
            await _productService.Update(productDto, cancellationToken);
        }
    }
}
