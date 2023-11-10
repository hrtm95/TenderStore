using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll(CancellationToken cancellationToken);
        Task Update(UserDto userDto , CancellationToken cancellationToken);
        Task Delete(int Id, CancellationToken cancellationToken);
        Task Create(UserDto userDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int userId, CancellationToken cancellationToken);
        Task DeActive(int userId, CancellationToken cancellationToken);
    }
}
