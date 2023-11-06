using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class SoldGoodsApplicationService : ISoldGoodsApplicationService
    {
        private readonly ISoldGoodsApplicationService _soldGoodsService;
        public SoldGoodsApplicationService(ISoldGoodsApplicationService soldService)
        {
            _soldGoodsService = soldService;
        }

        public Task Active(int soldgoodsId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(SoldGoodsDto soldDto, CancellationToken cancellationToken)
        {
            await _soldGoodsService.Create(soldDto, cancellationToken);
        }

        public Task DeActive(int soldgoodsId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SoldGoods>> GetAll(CancellationToken cancellationToken)
        => await _soldGoodsService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(SoldGoodsDto soldDto, CancellationToken cancellationToken)
        {
            await _soldGoodsService.Update(soldDto, cancellationToken);
        }
    }
}
