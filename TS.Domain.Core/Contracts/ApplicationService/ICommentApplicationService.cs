﻿using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface ICommentApplicationService
    {
        Task<Comment> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        Task Create(CommentDto entity, int orderId,CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task<List<Comment>> GetBy(Guid expertId, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
