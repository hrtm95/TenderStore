using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IOrderApplicationService
    {
        Task<Order> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Order>> GetAll(CancellationToken cancellationToken);
        Task Create(string ordername, CancellationToken cancellationToken);
        Task Update(Order entity, CancellationToken cancellationToken);
        Task Active(int orderId, CancellationToken cancellationToken);
        Task DeActive(int orderId, CancellationToken cancellationToken);
    }
}
