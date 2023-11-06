using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface ICustomAttributeService
    {
        Task<List<CustomAttribute>> GetAll(CancellationToken cancellationToken);
        Task Update(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken);
        Task Create(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int customAttributeId, CancellationToken cancellationToken);
        Task DeActive(int customAttributeId, CancellationToken cancellationToken);
    }
}
