using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Entities;

namespace TS.Endpoints.UI.Areas.Admin.Pages.SellerAdmin
{
    public class SellersListModel : PageModel
    {
        private readonly ISellerApplicationService _appService;
        public SellersListModel(ISellerApplicationService sellerApplicationService)
        {
            _appService = sellerApplicationService;
        }
        public IEnumerable<Seller> sellers { get; set; }

        public async Task<IActionResult> OnGet(CancellationToken cancellationToken)
        {
            sellers =  await _appService.GetAll(cancellationToken);
            return Page();
        }
    }
}
