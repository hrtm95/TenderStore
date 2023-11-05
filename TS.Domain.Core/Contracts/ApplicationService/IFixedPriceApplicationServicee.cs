using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IFixedPriceApplicationServicee
    {
        Task<List<FixedPrice>> GetAll(CancellationToken cancellationToken);
        Task Update(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken);
        Task Create(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int fixdPriceId, CancellationToken cancellationToken);
        Task DeActive(int fixdPriceId, CancellationToken cancellationToken);
    }
}
