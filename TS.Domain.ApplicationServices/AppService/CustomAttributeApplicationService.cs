using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class CustomAttributeApplicationService : ICustomAttributeApplicationService
    {
        private readonly ICustomAttributeApplicationService _customAttributeService;
        public CustomAttributeApplicationService(ICustomAttributeApplicationService customAttributeService)
        {
            _customAttributeService = customAttributeService;     
        }

        public Task Active(int customAttributeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken)
        {
            await _customAttributeService.Create(customAttributeTemplateDto, cancellationToken);
        }

        public Task DeActive(int customAttributeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomAttribute>> GetAll(CancellationToken cancellationToken)
        => await _customAttributeService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CustomAttributeDto customAttributeTemplateDto, CancellationToken cancellationToken)
        {
            await _customAttributeService.Update(customAttributeTemplateDto, cancellationToken);
        }
    }
}
