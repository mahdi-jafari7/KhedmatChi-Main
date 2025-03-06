using App.Domain.AppServices.Customer;
using App.Domain.Core.Contract.AppService_Interfaces;
using App.Domain.Core.Contract.Service_Interfaces;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.Services;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.EndPoints.UI.RazorPages.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ICustomerAppService _customerappService;
        private readonly IExpertAppService _expertService;
        private readonly IMainCategoryAppService _mainCategoryService;
        private readonly ICategoryAppService _CategoryService;
        private readonly IServiceAppService _serviceService;
        private readonly ICommentAppService _commentService;
        private readonly IServiceRequestAppService _serviceRequestAppService;
        private readonly IProposalAppService _proposalAppService;

        // Constructor Injection
        public IndexModel(
            ICustomerAppService customerappService,
            IExpertAppService expertService,
            IMainCategoryAppService mainCategoryService,
            ICategoryAppService CategoryService,
            IServiceAppService serviceService,
            ICommentAppService commentService,
            IServiceRequestAppService serviceRequestAppService,
            IProposalAppService proposalAppService)
        {
            _customerappService = customerappService;
            _expertService = expertService;
            _mainCategoryService = mainCategoryService;
            _CategoryService = CategoryService;
            _serviceService = serviceService;
            _commentService = commentService;
            _serviceRequestAppService = serviceRequestAppService;
            _proposalAppService = proposalAppService;
        }

        // Properties to hold counts
        public int CustomerCount { get; set; }
        public int ExpertCount { get; set; }
        public int MainCategoryCount { get; set; }
        public int CategoryCount { get; set; }
        public int ServiceCount { get; set; }
        public int CommentCount { get; set; }
        public int ServiceRequestCount { get; set; }
        public int ProposalCount { get; set; }

        // OnGet method to load data
        //public void OnGet()
        //{
        //    // Fetch counts from services
        //    CustomerCount = (_customerappService.GetCustomers()
        //    ExpertCount = _expertService.GetTotalExperts();
        //    MainCategoryCount = _mainCategoryService.GetTotalMainCategories();
        //    SubCategoryCount = _subCategoryService.GetTotalSubCategories();
        //    ServiceCount = _serviceService.GetTotalServices();
        //    CommentCount = _commentService.GetTotalComments();
        //    RequestCount = _requestService.GetTotalRequests();
        //    OfferCount = _offerService.GetTotalOffers();
        //}
    }
}
