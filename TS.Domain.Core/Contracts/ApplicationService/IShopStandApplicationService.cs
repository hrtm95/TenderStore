using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IShopStandApplicationService
    {
        Task<ShopStand> GetBy(int id, CancellationToken cancellationToken);
        Task<List<ShopStand>> GetAll(CancellationToken cancellationToken);
        Task Create(string ShopStandname, CancellationToken cancellationToken);
        Task Update(ShopStand entity, CancellationToken cancellationToken);
        Task Active(int shopStandId, CancellationToken cancellationToken);
        Task DeActive(int shopStandId, CancellationToken cancellationToken);
    }
}
