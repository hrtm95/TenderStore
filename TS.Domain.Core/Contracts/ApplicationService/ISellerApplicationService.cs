using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ISellerApplicationService
    {
        Task<Seller> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Seller>> GetAll(CancellationToken cancellationToken);
        Task Create(SellerDto Seller, CancellationToken cancellationToken);
        Task Update(SellerDto Seller, CancellationToken cancellationToken);
        Task Active(int sellerId, CancellationToken cancellationToken);
        Task DeActive(int sellerId, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);

    }
}
