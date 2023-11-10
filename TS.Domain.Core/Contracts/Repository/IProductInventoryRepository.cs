using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IProductInventoryRepository
    {
        Task<List<ProductInventory>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken);
        Task Create(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
