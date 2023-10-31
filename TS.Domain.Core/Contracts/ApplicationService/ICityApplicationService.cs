
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ICityApplicationService
    {
        Task<List<City>> Get(CancellationToken cancellationToken);
    }
}
