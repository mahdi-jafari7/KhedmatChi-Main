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


        public ExpertCommentModel(ICommentAppService commentAppService, IExpertAppService expertAppService)
        {
            _commentAppService = commentAppService;
            _expertAppService = expertAppService;

        }

        public List<CommentDto> Comments { get; set; }

        //public async Task<IActionResult> OnGetAsync(int? id)
        //{

        //    if (User.IsInRole("Expert"))
        //    {
        //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //var expertId = await _expertAppService.GetExpertIdByUserIdAsync(int.Parse(userId));
        //int expertIdValue = expertId ?? 0;


        //        Comments = await _commentAppService.GetCommentsByExpertIdAsync(expertIdValue);
        //    }
        //    //else if (id.HasValue)
        //    //{

        //    //    Comments = await _commentAppService.GetCommentsByExpertIdAsync(id.Value);
        //    //}
        //    else
        //    {
        //        Comments = await _commentAppService.GetCommentsByExpertIdAsync(id.Value);
        //        //Comments = new List<CommentDto>(); 
        //    }

        //    return Page();
        //}

        //public async Task<IActionResult> OnGetAsync(int expertId)
        //{

        //    if (expertId <= 0)
        //    {
        //        return NotFound();
        //    }


        //    Comments = await _commentAppService.GetCommentsByExpertIdAsync(expertId);
        //    return Page();
        //}

        public async Task<IActionResult> OnGetAsync(int? id, string expertEmail)
        {
            int? expertId = null;

            if (User.IsInRole("Expert"))
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                expertId = await _expertAppService.GetExpertIdByUserIdAsync(int.Parse(userId));
                int expertIdValue = expertId ?? 0;
            }
            else if (id.HasValue)
            {
                expertId = id.Value;
            }
            else if (!string.IsNullOrEmpty(expertEmail))
            {
                expertId = await _expertAppService.GetExpertIdByEmailAsync(expertEmail);
            }
            

            if (expertId.HasValue)
            {
                Comments = await _commentAppService.GetCommentsByExpertIdAsync(expertId.Value);
            }
            else
            {
                return NotFound("متخصصی پیدا نشد.");
            }

            return Page();
        }

    }
}
