using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class AuctionApplicationService : IAuctionApplicationService
    {
        private readonly IAuctionApplicationService _auctionService;
        public AuctionApplicationService(IAuctionApplicationService auctionService)
        {
            _auctionService = auctionService;  
        }

        public async Task Active(int auctionPriceId, CancellationToken cancellationToken)
        {
            await _auctionService.Active(auctionPriceId, cancellationToken);
        }

        public async Task Create(AuctionPriceDto auctionDto, CancellationToken cancellationToken)
        {
            await _auctionService.Create(auctionDto, cancellationToken);
        }

        public async Task DeActive(int auctionPriceId, CancellationToken cancellationToken)
        {
            await _auctionService.DeActive(auctionPriceId, cancellationToken);
        }

        public Task<List<AuctionPrice>> GetAll(CancellationToken cancellationToken)
        => _auctionService.GetAll(cancellationToken);
        public async Task Update(AuctionPriceDto auctionDto, CancellationToken cancellationToken)
        {
            await _auctionService.Update(auctionDto, cancellationToken);
        }

        public async Task<AuctionPrice> GetBy(int Id, CancellationToken cancellationToken)
            => await _auctionService.GetBy(Id, cancellationToken);
    }
}
