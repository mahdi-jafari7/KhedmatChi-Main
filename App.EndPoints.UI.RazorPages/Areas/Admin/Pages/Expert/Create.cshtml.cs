using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Expert
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly IExpertAppService _expertAppService;
        private readonly IBaseAppService _baseAppService;

        public CreateModel(IExpertAppService expertAppService,
            IBaseAppService baseAppService)
        {
            _expertAppService = expertAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public ExpertDto CreatingExpert{ get; set; }
        [BindProperty]
        [Required(ErrorMessage = "عکس الزامی است")]
        public IFormFile ExpertImage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile ExpertImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
                
            }

            var imageUrl = await _baseAppService.UploadImage(ExpertImage);
            CreatingExpert.ProfileImage = imageUrl;
            await _expertAppService.CreateExpert(CreatingExpert, cancellationToken);
            return LocalRedirect("~/Admin/Expert/Index");

        }
    }
}