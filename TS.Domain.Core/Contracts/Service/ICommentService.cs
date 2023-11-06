using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface ICommentService
    {
        Task<Comment> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        Task Create(CommentDto entity, CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
