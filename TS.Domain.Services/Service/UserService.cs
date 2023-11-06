using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserService _userService;
        public UserService(IUserService userService)
        {
            _userService = userService;  
        }

        public Task Active(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userService.Create(userDto, cancellationToken);
        }

        public Task DeActive(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        => await _userService.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userService.Update(userDto, cancellationToken);
        }
    }
}
