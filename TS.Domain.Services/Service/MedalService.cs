using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class MedalService : IMedalService
    {
        private readonly IMedalService _medalService;
        public MedalService(IMedalService medalService)
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

        public Task<Medal> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MedalDto medalDto, CancellationToken cancellationToken)
        {
            await _medalService.Update(medalDto, cancellationToken);
        }
    }
}
