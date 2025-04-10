using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Services;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages.Customer
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IBaseAppService _baseAppService;

        public UpdateModel(ICustomerAppService customerAppService,
            IBaseAppService baseAppService)
        {
            _customerAppService = customerAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public CustomerDto UpdatingCustomer { get; set; }

        [BindProperty]
        public IFormFile? customerImage { get; set; }

        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            UpdatingCustomer = await _customerAppService.GetCustomerById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(IFormFile? customerImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }

            if (customerImage is not null)
            {
                var imageUrl = await _baseAppService.UploadImage(customerImage);
                UpdatingCustomer.ProfileImage = imageUrl;
            }

            CustomerProfileDto updatedCustomer = new CustomerProfileDto()
            {
                FirstName = UpdatingCustomer.FirstName,
                LastName = UpdatingCustomer.LastName,
                Email = UpdatingCustomer.Email,
                ProfileImageUrl = UpdatingCustomer.ProfileImage

            };

            await _customerAppService.UpdateCustomer(updatedCustomer, cancellationToken);
            return LocalRedirect("~/Admin/Customer/Index");
        }
    }
}


