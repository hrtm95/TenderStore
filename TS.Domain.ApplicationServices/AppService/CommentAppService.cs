using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class CommentAppService : ICommentApplicationService
    {
        private readonly ICommentApplicationService _commentService;
        public CommentAppService(ICommentApplicationService commentService)
        {
            _commentService = commentService;
        }

        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
            await _commentService.Active(commentId, cancellationToken);

        }

        public async Task Create(CommentDto entity, CancellationToken cancellationToken)
        {
            await _commentService.Create(entity, cancellationToken);
        }

        public async Task DeActive(int commentId, CancellationToken cancellationToken)
        {
            await _commentService.DeActive(commentId, cancellationToken);
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
            => await _commentService.GetAll(cancellationToken);

        public async Task<Comment> GetBy(int id, CancellationToken cancellationToken)
            => await _commentService.GetBy(id, cancellationToken);


        public async Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            await _commentService.Update(entity, cancellationToken);
        }
    }
}
