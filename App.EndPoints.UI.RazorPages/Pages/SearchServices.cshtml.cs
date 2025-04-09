using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    public class SearchServicesModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;

        public SearchServicesModel(IServiceAppService serviceAppService)
        {
            _serviceAppService = serviceAppService;
        }

        public async Task<JsonResult> OnGetAsync(string term, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(term))
                return new JsonResult(new List<object>());

            var services = await _serviceAppService.SearchServicesByName(term, cancellationToken);

            var results = services.Select(s => new
            {
                id = s.Id,
                title = s.Title
            });

            return new JsonResult(results);
        }
    }
}
