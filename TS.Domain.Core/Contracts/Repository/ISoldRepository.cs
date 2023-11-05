using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface ISoldRepository
    {
        Task<List<SoldGoods>> GetAll(CancellationToken cancellationToken);
        Task Update(SoldGoodsDto soldDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(SoldGoodsDto soldDto , CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
