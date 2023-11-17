using Microsoft.AspNetCore.Identity;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll(CancellationToken cancellationToken);
        Task Update(UserDto userDto, CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task<IdentityResult> Create(UserDto userDto, CancellationToken cancellationToken);
        Task<User> GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int userId, CancellationToken cancellationToken);
        Task DeActive(int userId, CancellationToken cancellationToken);
        Task<SignInResult> Login(UserDto userDto, CancellationToken cancellationToken);
        Task<User> GetByEmail(string Email, CancellationToken cancellationToken);
        Task<IdentityRole<int>> FindUser(int Id, CancellationToken cancellationToken);

    }
}
