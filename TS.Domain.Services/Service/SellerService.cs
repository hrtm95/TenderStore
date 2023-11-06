using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class SellerService : ISellerService
    {
        private readonly ISellerService _sellerService;
        public SellerService(ISellerService sellerService)
        {
            _sellerService = sellerService;   
        }

        public Task Active(int sellerId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            await _sellerService.Create(sellerDto, cancellationToken);
        }

        public Task DeActive(int sellerId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Seller>> GetAll(CancellationToken cancellationToken)
        => await _sellerService.GetAll(cancellationToken);

        public Task<Seller> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            await _sellerService.Update(sellerDto, cancellationToken);   
        }
    }
}
