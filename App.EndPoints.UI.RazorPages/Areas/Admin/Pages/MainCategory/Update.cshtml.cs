using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Services;
using App.Domain.Core.Contract.AppService_Interfaces;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.MainCategory
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly IMainCategoryAppService _maincategoryAppService;
        private readonly IBaseAppService _baseAppService;

        public UpdateModel(IMainCategoryAppService maincategoryAppService,
            IBaseAppService baseAppService)
        {
            _maincategoryAppService = maincategoryAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public MainCategoryDTO UpdatingMainCategory { get; set; }

        [BindProperty]
        public IFormFile? MainCategoryImage { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingMainCategory = await _maincategoryAppService.GetMainCategoryById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(IFormFile? maincategoryImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToAction("OnGet", new { expertId = (int)TempData["ExpertId"] });
            }

            if (maincategoryImage is not null)
            {
                var imageUrl = await _baseAppService.UploadImage(maincategoryImage);
                UpdatingMainCategory.Image = imageUrl;
            }
            await _maincategoryAppService.UpdateMainCategory(UpdatingMainCategory, cancellationToken);
            return LocalRedirect("~/Admin/MainCategory/Index");
        }
    }
}
