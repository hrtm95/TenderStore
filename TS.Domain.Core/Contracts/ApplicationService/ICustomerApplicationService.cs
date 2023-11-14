using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ICustomerApplicationService
    {
        Task<List<Customer>> GetAll(CancellationToken cancellationToken);
        Task Update(CustomerDto addressDto, CancellationToken cancellationToken);
        Task Create(CustomerDto addressDto, CancellationToken cancellationToken);
        Task<Customer> GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int Id, CancellationToken cancellationToken);
        Task DeActive(int Id, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);

    }
}
