using App.Domain.AppServices.Admin;
using App.Domain.Core.Admin.AppServices;
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
    public class CreateModel : PageModel
    {
        private readonly Domain.Core.Customer.AppServices.ICustomerAppService _customerAppService;
        private readonly IBaseAppService _baseAppService;
       

        public CreateModel(Domain.Core.Customer.AppServices.ICustomerAppService customerAppService,
            IBaseAppService baseAppService)

        {
            _customerAppService = customerAppService;
            _baseAppService = baseAppService;
            
        }

        [BindProperty]
        public CustomerDto CreatingCustomer { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "عکس الزامی است")]
        public IFormFile CustomerImage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile CustomerImage, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
               
                return Page();
            }

            
            if (CustomerImage == null || CustomerImage.Length == 0)
            {
                ModelState.AddModelError(nameof(CustomerImage), "لطفاً یک تصویر انتخاب کنید.");
                return Page();
            }

           
            var imageUrl = await _baseAppService.UploadImage(CustomerImage);
            if (string.IsNullOrEmpty(imageUrl))
            {
                ModelState.AddModelError(nameof(CustomerImage), "آپلود تصویر با مشکل مواجه شد.");
                return Page();
            }

           
            CreatingCustomer.ProfileImage = imageUrl;

           
            await _customerAppService.CreateCustomer(CreatingCustomer, cancellationToken);

           
            return LocalRedirect("~/Admin/Customer/Index");
        }
    }
}