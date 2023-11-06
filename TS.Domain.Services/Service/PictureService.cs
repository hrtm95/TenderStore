using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class PictureService : IPictureService
    {
        private readonly IPictureService _pictureService;
        public PictureService(IPictureService pictureService)
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
