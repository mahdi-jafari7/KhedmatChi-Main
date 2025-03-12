using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Proposal
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IProposalAppService _proposalAppService;

        public IndexModel(IProposalAppService proposalAppService)
        {
            _proposalAppService = proposalAppService;
        }

        [BindProperty]
        public ProposalConfirmationDto proposalconfirmation { get; set; }
        public List<ProposalDto> ProposalDto { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            ProposalDto = await _proposalAppService.GetProposals(cancellationToken);
        }


        public async Task<IActionResult> OnPostDelete(int id, CancellationToken cancellationToken)
        {
            await _proposalAppService.SoftDeleteProposal(id, cancellationToken);
            return RedirectToPage();
        }


    }
}
