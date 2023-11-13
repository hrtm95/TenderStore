using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Entities;

namespace TS.Endpoints.UI.Areas.Admin.UsersAdmin
{
    public class UsersListModel : PageModel
    {
        private readonly IUserApplicationService _userApplicationService;
        public UsersListModel(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }

        public IEnumerable<User> Users { get; set; }
        public async Task<IActionResult> OnGet(CancellationToken cancellationToken)
        {
            Users = await _userApplicationService.GetAll(cancellationToken);
            return Page();
        }
    }
}
