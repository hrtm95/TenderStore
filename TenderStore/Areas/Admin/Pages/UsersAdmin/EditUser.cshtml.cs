using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Endpoints.UI.Areas.Admin.Pages.UsersAdmin
{
    public class EditUserModel : PageModel
    {
        private readonly IUserApplicationService _UserAppService;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;

        public EditUserModel(IUserApplicationService userAppService, IMapper mapper, SignInManager<User> signInManager)
        {
            _UserAppService = userAppService;
            _mapper = mapper;
            _signInManager = signInManager;
        }
        public User user { get; set; }
        public UserDto role { get; set; }
        public async Task<IActionResult> OnGet(int Id, CancellationToken cancellationToken)
        {
            user = await _UserAppService.GetBy(Id, cancellationToken);
            //var userEmail = user.Email;
            //var UserId = await _UserAppService.GetByEmail(userEmail, cancellationToken);
            //var Role = _signInManager.UserManager.GetRolesAsync(UserId).Result;
            //var RoleName = Role.SingleOrDefault();

            return Page();
        }

        public async Task<IActionResult> OnPostUpdate(UserDto model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {

                await _UserAppService.Update(model, cancellationToken);

                try
                {
                    return LocalRedirect("/Admin/UsersList");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }


            }
            return default;
        }
    }
}
