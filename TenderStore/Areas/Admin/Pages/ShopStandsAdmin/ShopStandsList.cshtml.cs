using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.ApplicationServices.AppService;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Entities;

namespace TS.Endpoints.UI.Areas.Admin.Pages.ShopStandsAdmin
{
    public class ShopStandsListModel : PageModel
    {
        private readonly IShopStandApplicationService _ShopStandApplicationService;
        public ShopStandsListModel(IShopStandApplicationService ShopStandApplicationService)
        {
            _ShopStandApplicationService = ShopStandApplicationService;
        }

        public IEnumerable <ShopStand> shopStands { get; set; }
        public async Task<IActionResult> OnGet(CancellationToken cancellationToken)
        {
            shopStands = await _ShopStandApplicationService.GetAll(cancellationToken);
            return Page();
        }
    }
}
