using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class FixedPriceApplicationService : IFixedPriceApplicationServicee
    {
        private readonly IFixedPriceApplicationServicee _fixedPriceService;
        public FixedPriceApplicationService(IFixedPriceApplicationServicee fixedPriceService)
        {
            _fixedPriceService = fixedPriceService;
        }

        public Task Active(int fixdPriceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken)
        {
            await _fixedPriceService.Create(fixedPriceDto, cancellationToken);
        }

        public Task DeActive(int fixdPriceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FixedPrice>> GetAll(CancellationToken cancellationToken)
        => await _fixedPriceService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(FixedPriceDto fixedPriceDto, CancellationToken cancellationToken)
        {
            await _fixedPriceService.Update(fixedPriceDto, cancellationToken);
        }
    }
}
