using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class ProductInventoryService : IProductInventoryService
    {
        private readonly IProductInventoryService _productInventoryService;
        public ProductInventoryService(IProductInventoryService productInventoryService)
        {
            _productInventoryService = productInventoryService;
        }

        public Task Active(int productInventoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken)
        {
            await _productInventoryService.Create(productInventoryDto, cancellationToken);
        }

        public Task DeActive(int productInventoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductInventory>> GetAll(CancellationToken cancellationToken)
        => await _productInventoryService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken)
        {
            await _productInventoryService.Update(productInventoryDto, cancellationToken);
        }
    }
}
