using Microsoft.AspNetCore.Identity;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IUserApplicationService
    {
        Task<List<User>> GetAll(CancellationToken cancellationToken);
        Task Update(UserDto userDto, CancellationToken cancellationToken);
        Task<IdentityResult> Create(UserDto userDto, CancellationToken cancellationToken);
        Task GetBy(int Id, CancellationToken cancellationToken);
        Task Active(int userId, CancellationToken cancellationToken);
        Task DeActive(int userId, CancellationToken cancellationToken);
    }
}
