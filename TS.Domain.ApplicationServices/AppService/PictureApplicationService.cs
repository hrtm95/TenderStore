using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class PictureApplicationService : IPictureApplicationService
    {
        private readonly IPictureApplicationService _pictureService;
        public PictureApplicationService(IPictureApplicationService pictureService)
        {
            _pictureService = pictureService;   
        }

        public Task Active(int pictureId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(PictureDto pictureDto, CancellationToken cancellationToken)
        {
            await _pictureService.Create(pictureDto, cancellationToken).ConfigureAwait(false);
        }

        public Task DeActive(int pictureId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Picture>> GetAll(CancellationToken cancellationToken)
        => await _pictureService.GetAll(cancellationToken).ConfigureAwait(false);

        public Task<Picture> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(PictureDto pictureDto, CancellationToken cancellationToken)
        {
            await _pictureService.Update(pictureDto, cancellationToken).ConfigureAwait(false);
        }
    }
}
