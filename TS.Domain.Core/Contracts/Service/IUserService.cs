using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.Service
{
    public interface IUserService
    {
        Task<List<User>> GetAll(CancellationToken cancellationToken);
        Task Update(UserDto userDto, CancellationToken cancellationToken);
        Task Create(UserDto userDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int userId, CancellationToken cancellationToken);
        Task DeActive(int userId, CancellationToken cancellationToken);
    }
}
