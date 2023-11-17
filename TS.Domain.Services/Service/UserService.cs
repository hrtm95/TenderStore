using Microsoft.AspNetCore.Identity;
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

        public async Task Active(int userId, CancellationToken cancellationToken)
        {
           await _userRepository.Active(userId, cancellationToken);
        }

        public async Task<IdentityResult> Create(UserDto userDto, CancellationToken cancellationToken)
     => await _userRepository.Create(userDto, cancellationToken);


        public async Task DeActive(int userId, CancellationToken cancellationToken)
        {
            await _userRepository.DeActive(userId, cancellationToken);
        }

        public Task Delete(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        => await _userRepository.GetAll(cancellationToken);

        public async Task<User> GetBy(int Id, CancellationToken cancellationToken)
        => await _userRepository.GetBy(Id, cancellationToken);

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userRepository.Update(userDto, cancellationToken);
        }
        public async Task<User> GetByEmail(string Email, CancellationToken cancellationToken)
            => await _userRepository.GetByEmail(Email, cancellationToken);

        public async Task<SignInResult> Login(UserDto userDto, CancellationToken cancellationToken)
            => await _userRepository.Login(userDto, cancellationToken);
        public async Task<IdentityRole<int>> FindUser(int Id, CancellationToken cancellationToken)
            => await _userRepository.FindUser(Id, cancellationToken);

    }
}
