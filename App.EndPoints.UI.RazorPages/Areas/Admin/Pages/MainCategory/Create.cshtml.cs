using App.Domain.Core.Admin.AppServices;
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
    public class CreateModel : PageModel
    {
        private readonly IMainCategoryAppService _maincategoryAppService;
        private readonly IBaseAppService _baseAppService;

        public CreateModel(IMainCategoryAppService maincategoryAppService,
            IBaseAppService baseAppService)
        {
            _maincategoryAppService = maincategoryAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public MainCategoryDTO CreatingMainCategory { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "عکس الزامی است")]
        public IFormFile MainCategoryImage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile MaincategoryImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                
            }

            var imageUrl = await _baseAppService.UploadImage(MaincategoryImage);
            CreatingMainCategory.Image = imageUrl;
            await _maincategoryAppService.CreateMainCategory(CreatingMainCategory, cancellationToken);

            TempData["SuccessMessage"] = $"دسته بندی {CreatingMainCategory.Title} با موفقییت اضافه شد";
            return LocalRedirect("~/Admin/MainCategory/Index");

        }
    }
}
