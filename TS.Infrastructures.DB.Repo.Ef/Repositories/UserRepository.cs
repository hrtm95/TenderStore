using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _db;

        public UserRepository(DbContext db)
        {
            _db = db;
        }
        public async Task Create(UserDto userDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
