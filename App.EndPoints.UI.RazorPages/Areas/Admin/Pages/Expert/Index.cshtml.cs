using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Expert
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IExpertAppService _expertAppservice;

        public IndexModel(IExpertAppService expertAppservice)
        {
            _expertAppservice = expertAppservice;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _expertAppservice.SoftDeleteExpert(id, cancellationToken);
            return RedirectToPage();
        }

        
    }
}
