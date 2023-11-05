using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAll(CancellationToken cancellationToken);
        Task Update (AddressDto addressDto,CancellationToken cancellationToken);
        Task Delete (int Id, CancellationToken cancellationToken);    
        Task Create (AddressDto addressDto, CancellationToken cancellationToken);
        Task<AddressDto> GetBy (int Id, CancellationToken cancellationToken);
    }
}
