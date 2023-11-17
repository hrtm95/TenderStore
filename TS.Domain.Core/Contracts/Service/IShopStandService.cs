using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IShopStandService
    {
        Task<ShopStand> GetBy(int id, CancellationToken cancellationToken);
        Task<List<ShopStand>> GetAll(CancellationToken cancellationToken);
        Task Create(ShopStandDto entity, CancellationToken cancellationToken);
        Task Update(ShopStandDto entity, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Active(int shopStandId, CancellationToken cancellationToken);
        Task DeActive(int shopStandId, CancellationToken cancellationToken);
    }
}
