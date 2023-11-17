using Microsoft.AspNetCore.Identity;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.ApplicationServices.AppService
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserService _userService;
        public UserApplicationService(IUserService userService)
        {
            _userService = userService;  
        }

        public Task Active(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> Create(UserDto userDto, CancellationToken cancellationToken)
        {
            var result = await _userService.Create(userDto, cancellationToken);
            if (result.Succeeded)
            {
                //var confirmKey = await _userService.SendEmailActivation(command.Email, cancellationToken);
                //await _userService.SetConfirmKey(command.Email, confirmKey);
                return result;
            }
            else
            {
                return result;
            }


        }

        public Task DeActive(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        => await _userService.GetAll(cancellationToken);

        public async Task<User> GetBy(int Id, CancellationToken cancellationToken)
        => await _userService.GetBy(Id, cancellationToken);

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userService.Update(userDto, cancellationToken);
        }
        public Task<SignInResult> Login(UserDto userDto, CancellationToken cancellationToken)
        {

            return _userService.Login(userDto, cancellationToken);
        }
        public async Task<IdentityRole<int>> FindUser(int Id, CancellationToken cancellationToken)
        => await _userService.FindUser(Id, cancellationToken);
        public async Task<User> GetByEmail(string Email, CancellationToken cancellationToken)
        => await _userService.GetByEmail(Email, cancellationToken);

    }
}
