using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class AuctionInformationService : IAuctionInformationService
    {
        private readonly IAuctionInformationService _auctionInformationService;
        public AuctionInformationService(IAuctionInformationService auctionInformationService)
        {
            _auctionInformationService = auctionInformationService;
        }

        public async Task Active(int AuctionInformationId, CancellationToken cancellationToken)
        {
            await _auctionInformationService.Active(AuctionInformationId, cancellationToken);
        }

        public async Task Create(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken)
        {
            await _auctionInformationService.Create(auctionInformationDto, cancellationToken);
        }

        public async Task DeActive(int AuctionInformationId, CancellationToken cancellationToken)
        {
            await _auctionInformationService.DeActive(AuctionInformationId, cancellationToken);
        }

        public async Task<List<AuctionInformation>> GetAll(CancellationToken cancellationToken)
       => await _auctionInformationService.GetAll(cancellationToken);

        public async Task<AuctionInformation> GetBy(int id, CancellationToken cancellationToken)
            => await _auctionInformationService.GetBy(id, cancellationToken);

        public async Task Update(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken)
        {
            await _auctionInformationService.Update(auctionInformationDto, cancellationToken);
        }
    }
}
