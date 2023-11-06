using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class ProductCustomAttributeService : IProductCustomAttributeService
    {
        private readonly IProductCustomAttributeService _productCustomAttributeService;
        public ProductCustomAttributeService(IProductCustomAttributeService productCustomAttributeService)
        {
            _productCustomAttributeService = productCustomAttributeService;    
        }

        public Task Active(int productCustomAttributeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken)
        {
            await _productCustomAttributeService.Create(productCustomAttributeDto, cancellationToken);
        }

        public Task DeActive(int productCustomAttributeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductCustomAttribute>> GetAll(CancellationToken cancellationToken)
        => await _productCustomAttributeService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken)
        {
            await _productCustomAttributeService.Update(productCustomAttributeDto, cancellationToken);
        }
    }
}
