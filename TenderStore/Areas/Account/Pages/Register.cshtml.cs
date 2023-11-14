using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Dtos;
using TS.Endpoints.UI.Models.ViewModel;

namespace TS.Endpoints.UI.Areas.Account.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserApplicationService _UserAppService;
        private readonly IMapper _mapper;

        public RegisterModel(IUserApplicationService userAppService, IMapper mapper)
        {
            _UserAppService = userAppService;
            _mapper = mapper;
        }
        public async Task<IActionResult> OnPostCreate(RegisterViewModel model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var result = await _UserAppService.Create(_mapper.Map<UserDto>(model), cancellationToken);
                if (result.Succeeded)
                {
                    return LocalRedirect("/Account/Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                        return default;
                    }
                }
            }
            return default;
        }
    }
}
