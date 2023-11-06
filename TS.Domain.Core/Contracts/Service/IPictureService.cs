using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IPictureService
    {
        Task<Picture> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Picture>> GetAll(CancellationToken cancellationToken);
        Task Create(PictureDto entity, CancellationToken cancellationToken);
        Task Update(PictureDto entity, CancellationToken cancellationToken);
        Task Active(int pictureId, CancellationToken cancellationToken);
        Task DeActive(int pictureId, CancellationToken cancellationToken);
    }
}
