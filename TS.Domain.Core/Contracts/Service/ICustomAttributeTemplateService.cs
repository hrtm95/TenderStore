using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface ICustomAttributeService
    {
        Task<List<CustomAttribute>> GetAll(CancellationToken cancellationToken);
        Task Update(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
    }
}
