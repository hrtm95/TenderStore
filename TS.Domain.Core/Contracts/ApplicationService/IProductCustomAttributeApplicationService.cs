using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IProductCustomAttributeApplicationService
    {
        Task<List<ProductCustomAttribute>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken);
        Task Create(ProductCustomAttributeDto productCustomAttributeDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int productCustomAttributeId, CancellationToken cancellationToken);
        Task DeActive(int productCustomAttributeId, CancellationToken cancellationToken);
    }
}
