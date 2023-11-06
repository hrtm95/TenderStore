using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IAuctionInformationService
    {

        Task<AuctionInformation> GetBy(int id, CancellationToken cancellationToken);
        Task<List<AuctionInformation>> GetAll(CancellationToken cancellationToken);
        Task Create(AuctionInformationDto entity, CancellationToken cancellationToken);
        Task Update(AuctionInformationDto entity, CancellationToken cancellationToken);
        Task Active(int AuctionInformationId, CancellationToken cancellationToken);
        Task DeActive(int AuctionInformationId, CancellationToken cancellationToken);
    }
}
