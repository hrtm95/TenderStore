using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class AddressApplicationService : IAddressApplicationService
    {
        private readonly IAddressApplicationService _addressService;
        public AddressApplicationService(IAddressApplicationService addressService)
        {
            _addressService = addressService;
        }

        public async Task Active(int AddressId, CancellationToken cancellationToken)
        {
            await _addressService.Active(AddressId,cancellationToken);
        }
        public async Task DeActive(int AddressId, CancellationToken cancellationToken)
        {
            await _addressService.DeActive(AddressId, cancellationToken);
        }

        public async Task Create(AddressDto addressDto, CancellationToken cancellationToken)
        {
            await _addressService.Create(addressDto, cancellationToken);
        }

        public async Task<List<Address>> GetAll(CancellationToken cancellationToken)
            => await _addressService.GetAll(cancellationToken);


        public async Task Update(AddressDto addressDto, CancellationToken cancellationToken)
        {
            await _addressService.Update(addressDto, cancellationToken);
        }

        public async Task<Address> GetBy(int Id, CancellationToken cancellationToken)
            => await _addressService.GetBy(Id, cancellationToken);
    }
}
