using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task Active(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userRepository.Create(userDto, cancellationToken);
        }

        public Task DeActive(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        => await _userRepository.GetAll(cancellationToken);

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userRepository.Update(userDto, cancellationToken);
        }
    }
}
