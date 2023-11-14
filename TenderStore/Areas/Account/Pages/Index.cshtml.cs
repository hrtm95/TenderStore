using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Endpoints.UI.Areas.Account.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IUserApplicationService _UserAppService;
        private readonly IMapper _mapper;
        private readonly UserManager<User>? _userManager;

        public IndexModel(SignInManager<User> signInManager, IUserApplicationService UserAppService, IMapper mapper, UserManager<User>? userManager)
        {
            _UserAppService = UserAppService;
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;

        }
        public void OnGet()
        {
        }
        public async Task OnPostLogout()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<IActionResult> OnPostIndex(UserDto model, CancellationToken cancellationToken)
        {


            var result = await _UserAppService.Login(model, cancellationToken);
            var userEmail = model.Email;
            var UserId = await _UserAppService.GetByEmail(userEmail, cancellationToken);
            var Role = _signInManager.UserManager.GetRolesAsync(UserId).Result;
            var RoleName = Role.SingleOrDefault();

            if (result.Succeeded)
            {
                if (RoleName == "Customer")
                {
                    return LocalRedirect("/index/");
                }
                else if (RoleName == "Seller")
                {
                    return LocalRedirect("/index/");
                }
                else
                {
                    return LocalRedirect("/Admin/");
                }

            }
            ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است *");

            return default;
        }
    }
}
