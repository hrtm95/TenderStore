using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IAuctionApplicationService
    {
        Task<List<AuctionPrice>> GetAll(CancellationToken cancellationToken);
        Task Update(AuctionPriceDto auctionDto, CancellationToken cancellationToken);
        Task Create(AuctionPriceDto auctionDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int auvtionPriceId, CancellationToken cancellationToken);
        Task DeActive(int auvtionPriceId, CancellationToken cancellationToken);
    }
}
