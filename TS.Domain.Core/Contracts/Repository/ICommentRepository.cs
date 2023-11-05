using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        Task<CommentDto> Get(int Id, CancellationToken cancellationToken);
        Task<List<CommentDto>> Get(CancellationToken cancellationToken);
        Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        Task Create(string comment, Guid expertId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
