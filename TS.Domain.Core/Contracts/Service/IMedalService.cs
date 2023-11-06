using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IMedalService
    {
        Task<Medal> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Medal>> GetAll(CancellationToken cancellationToken);
        Task Create(MedalDto entity, CancellationToken cancellationToken);
        Task Update(MedalDto entity, CancellationToken cancellationToken);
        Task Active(int medalId, CancellationToken cancellationToken);
        Task DeActive(int medalId, CancellationToken cancellationToken);
    }
}
