using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IMedalApplicationService
    {
        Task<Medal> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Medal>> GetAll(CancellationToken cancellationToken);
        Task Create(double FeePercentage, CancellationToken cancellationToken);
        Task Update(Medal entity, CancellationToken cancellationToken);
        Task Active(int medalId, CancellationToken cancellationToken);
        Task DeActive(int medalId, CancellationToken cancellationToken);
    }
}
