using App.Domain.Core.Customer.AppServices;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRequestsController : ControllerBase
    {
        private readonly IServiceRequestAppService _serviceRequestAppService;

        public ServiceRequestsController(IServiceRequestAppService serviceRequestAppService)
        {
            _serviceRequestAppService = serviceRequestAppService;
        }

        [HttpGet]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> GetServiceRequests(CancellationToken cancellationToken)
        {
            try
            {
                var serviceRequests = await _serviceRequestAppService.GetServiceRequests(cancellationToken);

                if (serviceRequests == null || serviceRequests.Count == 0)
                    return NotFound("No service requests found.");

                return Ok(serviceRequests);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}