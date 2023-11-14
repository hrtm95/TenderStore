using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TS.Endpoints.UI.Areas.Admin.Pages
{
    [Authorize("Admin")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
