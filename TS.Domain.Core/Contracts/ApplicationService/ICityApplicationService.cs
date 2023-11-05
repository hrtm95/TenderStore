
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ICityApplicationService
    {

        Task<City> GetBy(int id, CancellationToken cancellationToken);
        Task<List<City>> GetAll(CancellationToken cancellationToken);
        Task Create(CityDto entity, CancellationToken cancellationToken);
        Task Update(CityDto entity, CancellationToken cancellationToken);
        Task Active(int CityId, CancellationToken cancellationToken);
        Task DeActive(int CityId, CancellationToken cancellationToken);
    }
}
