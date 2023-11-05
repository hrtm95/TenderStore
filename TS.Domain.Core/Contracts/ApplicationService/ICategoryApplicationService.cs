using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ICategoryApplicationService
    {
        Task<Category> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Category>> GetAll(CancellationToken cancellationToken);
        Task Create(CategoryDto entity, CancellationToken cancellationToken);
        Task Update(CategoryDto entity, CancellationToken cancellationToken);
        Task Active(int categoryId, CancellationToken cancellationToken);
        Task DeActive(int categoryId, CancellationToken cancellationToken);
    }
}
