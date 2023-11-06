using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductApplicationService _productService;
        public ProductApplicationService(IProductApplicationService productService)
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

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductDto productDto, CancellationToken cancellationToken)
        {
            await _productService.Update(productDto, cancellationToken);
        }

        Task<Product> IProductApplicationService.GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
