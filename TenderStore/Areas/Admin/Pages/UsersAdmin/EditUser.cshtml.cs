using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TS.Endpoints.UI.Areas.Admin.Pages.UsersAdmin
{
    [Authorize("Admin")]
    public class EditUserModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
