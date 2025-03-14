using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Services;
using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class ExpertCommentModel : PageModel
    {
        private readonly ICommentAppService _commentAppService;
        private readonly IExpertAppService _expertAppService;


        public ExpertCommentModel(ICommentAppService commentAppService,IExpertAppService expertAppService)
        {
            _commentAppService = commentAppService;
            _expertAppService = expertAppService;

        }

        public List<CommentDto> Comments { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var expertId =await _expertAppService.GetExpertIdByUserIdAsync(int.Parse(userId));

            int expertIdValue = expertId ?? 0;

            Comments = await _commentAppService.GetCommentsByExpertIdAsync(expertIdValue);
            return Page();
        }
    }
}
