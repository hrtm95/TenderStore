using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class CommentRepository : ICommentRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public CommentRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string comment, Guid expertId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeActive(int commentId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> Get(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
