using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IFixedPriceRepository
    {
        Task<List<FixedPrice>> GetAll(CancellationToken cancellationToken);
        Task Update(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
