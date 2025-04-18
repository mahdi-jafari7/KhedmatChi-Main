using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Customer
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ICustomerAppService _customerAppService;

        public IndexModel(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public List<CustomerDto> Customers { get; set; }

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Customers = await _customerAppService.GetCustomers(cancellationToken);
        }
    

        public async Task<IActionResult> OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _customerAppService.SoftDeleteCustomer(id, cancellationToken);
            return RedirectToPage();
        }

        
    }
}
