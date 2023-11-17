using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class SellerService : ISellerService
    {
        private readonly ISellerRepository _sellerRepository;
        public SellerService(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;   
        }

        public Task Active(int sellerId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            await _sellerRepository.Create(sellerDto, cancellationToken);
        }

        public Task DeActive(int sellerId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Seller>> GetAll(CancellationToken cancellationToken)
        => await _sellerRepository.GetAll(cancellationToken);

        public Task<Seller> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(SellerDto sellerDto, CancellationToken cancellationToken)
        {
            await _sellerRepository.Update(sellerDto, cancellationToken);   
        }
    }
}
