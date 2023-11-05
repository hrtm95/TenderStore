using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IProductInventoryService
    {
        Task<List<ProductInventory>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
