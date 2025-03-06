using App.Domain.Core.Contract.AppService_Interfaces;
using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.MainCategory
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IMainCategoryAppService _maincategoryAppService;

        public IndexModel(IMainCategoryAppService maincategoryAppService)
        {
            _maincategoryAppService = maincategoryAppService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _maincategoryAppService.SoftDeleteMainCategory(id, cancellationToken);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetRestore(int id, CancellationToken cancellationToken)
        {
            await _maincategoryAppService.RestoreDeletedMainCategory(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
