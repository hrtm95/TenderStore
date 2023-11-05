using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ISoldGoodsApplicationService
    {
        Task<List<SoldGoods>> GetAll(CancellationToken cancellationToken);
        Task Update(SoldGoodsDto entity, CancellationToken cancellationToken);
        Task Create(SoldGoodsDto entity, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int soldgoodsId, CancellationToken cancellationToken);
        Task DeActive(int soldgoodsId, CancellationToken cancellationToken);
    }
}
