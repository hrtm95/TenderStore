using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class MedalApplicationService : IMedalApplicationService
    {
        private readonly IMedalApplicationService _medalService;
        public MedalApplicationService(IMedalApplicationService medalService)
        {
            _medalService = medalService;
        }

        public Task Active(int medalId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(MedalDto medalDto, CancellationToken cancellationToken)
        {
            await _medalService.Create(medalDto, cancellationToken);
        }

        public Task DeActive(int medalId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Medal>> GetAll(CancellationToken cancellationToken)
        => await _medalService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MedalDto medalDto, CancellationToken cancellationToken)
        {
            await _medalService.Update(medalDto, cancellationToken);
        }

        Task<Medal> IMedalApplicationService.GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
