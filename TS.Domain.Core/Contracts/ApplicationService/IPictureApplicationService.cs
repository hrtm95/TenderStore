using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IPictureApplicationService
    {
        Task<Picture> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Picture>> GetAll(CancellationToken cancellationToken);
        Task Create(PictureDto entity, CancellationToken cancellationToken);
        Task Update(PictureDto entity, CancellationToken cancellationToken);
        Task Active(int pictureId, CancellationToken cancellationToken);
        Task DeActive(int pictureId, CancellationToken cancellationToken);
    }
}
