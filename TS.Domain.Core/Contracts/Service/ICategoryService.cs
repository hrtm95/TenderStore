using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface ICategoryService
    {
        Task<Category> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Category>> GetAll(CancellationToken cancellationToken);
        Task Create(CategoryDto entity, CancellationToken cancellationToken);
        Task Update(CategoryDto entity, CancellationToken cancellationToken);
        Task Active(int categoryId, CancellationToken cancellationToken);
        Task DeActive(int categoryId, CancellationToken cancellationToken);
    }
}
