using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class ShopStandService : IShopStandService
    {
        private readonly IShopStandService _ShopStandRepository;
        public ShopStandService(IShopStandService ShopStandRepository)
        {
            _ShopStandRepository = ShopStandRepository; 
        }

        public async Task Active(int shopStandId, CancellationToken cancellationToken)
        {
            await _ShopStandRepository.Active(shopStandId, cancellationToken);
        }

        public async Task Create(ShopStandDto shopStandDto, CancellationToken cancellationToken)
        {
            await _ShopStandRepository.Create(shopStandDto, cancellationToken);
        }

        public async Task DeActive(int shopStandId, CancellationToken cancellationToken)
        {
            await _ShopStandRepository.DeActive(shopStandId, cancellationToken);
        }

        public async Task<List<ShopStand>> GetAll(CancellationToken cancellationToken)
        => await _ShopStandRepository.GetAll(cancellationToken);

        public async Task<ShopStand> GetBy(int id, CancellationToken cancellationToken)
            => await _ShopStandRepository.GetBy(id, cancellationToken);

        public async Task Update(ShopStandDto shopStandDto, CancellationToken cancellationToken)
        {
            await _ShopStandRepository.Update(shopStandDto, cancellationToken);
        }
    }
}
