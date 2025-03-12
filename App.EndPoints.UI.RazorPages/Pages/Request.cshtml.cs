using App.Domain.AppServices.Customer;
using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Pages
{
    //[Authorize(Roles = "Customer")]
    public class RequestModel : PageModel
    {
        private readonly IServiceAppService _serviceAppService;
        private readonly IServiceRequestAppService _serviceRequestAppService;
        private readonly ICustomerAppService _customerAppService;
        private readonly IBaseAppService _baseAppService;


        public RequestModel(IServiceAppService serviceAppService,
            IServiceRequestAppService serviceRequestAppService,
            ICustomerAppService customerAppService,
            IBaseAppService baseAppService)
        {
            _serviceAppService = serviceAppService;
            _serviceRequestAppService = serviceRequestAppService;
            _customerAppService = customerAppService;
            _baseAppService = baseAppService;
        }

        [BindProperty]
        public ServiceRequestDto ServiceRequest { get; set; }
        public ServiceDto SelectedService { get; set; }
        [BindProperty]
        public IFormFile? ServiceRequestImage { get; set; }


        public async Task OnGet(int? serviceId, CancellationToken cancellationToken)
        {
            if (serviceId == null)
            {
                ModelState.AddModelError("", "شناسه سرویس نامعتبر است.");
                return;
            }

            SelectedService = await _serviceAppService.GetServiceById(serviceId.Value, cancellationToken);
            ServiceRequest = new ServiceRequestDto { ServiceId = serviceId.Value };
        }

        //public async Task<IActionResult> OnPostAsync(IFormFile ServiceRequestImage, CancellationToken cancellationToken)
        //{
        //    if (User.IsInRole("Customer"))
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return RedirectToAction("OnGet", new { serviceId = ServiceRequest.ServiceId });

        //        }
        //        var applicationUserId = int.Parse(User.Claims.First().Value);
        //        int? userId;

        //        var user = User.Claims.FirstOrDefault(c => c.Type == "userCustomerId");
        //        if (user is not null)
        //        {
        //            userId = int.Parse(user.Value);
        //        }
        //        else
        //        {
        //            userId = await _customerAppService.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);
        //        }



        //        ServiceRequest.CustomerId = userId.Value;
        //        await _serviceRequestAppService.CreateServiceRequest(ServiceRequest, cancellationToken);
        //    }
        //    return LocalRedirect("~/MyRequests");

        //}

        public async Task<IActionResult> OnPostAsync([FromForm] IFormFile ServiceRequestImage, CancellationToken cancellationToken)
        {
            if (ServiceRequest == null)
            {
                ServiceRequest = new ServiceRequestDto();
            }

            if (ServiceRequestImage != null)
            {
                var imageUrl = await _baseAppService.UploadImage(ServiceRequestImage);
                ServiceRequest.ServiceImageUrl = imageUrl;
            }

            if (User.IsInRole("Customer"))
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToPage("Request", new { serviceId = ServiceRequest.ServiceId });
                }

                var applicationUserId = int.Parse(User.Claims.First().Value);
                int? userId = User.Claims.FirstOrDefault(c => c.Type == "userCustomerId") is { } user
                    ? int.Parse(user.Value)
                    : await _customerAppService.GetCustomerIdByApplicationUserId(applicationUserId, cancellationToken);

                ServiceRequest.CustomerId = userId.Value;

                await _serviceRequestAppService.CreateServiceRequest(ServiceRequest, cancellationToken);
            }

            return LocalRedirect("~/MyRequests");
        }


    }
}