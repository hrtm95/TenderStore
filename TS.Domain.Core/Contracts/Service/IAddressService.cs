using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IAddressService
    {
        Task<List<Address>> GetAll(CancellationToken cancellationToken);
        Task Update(AddressDto addressDto, CancellationToken cancellationToken);
        Task Create(AddressDto addressDto, CancellationToken cancellationToken);
        Task<Address> GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int AddressId, CancellationToken cancellationToken);
        Task DeActive(int AddressId, CancellationToken cancellationToken);
    }
}
