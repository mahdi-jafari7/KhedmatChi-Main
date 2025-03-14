using App.Domain.Core.Expert.AppServices;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [HttpGet("categories-with-services")]
        public async Task<IActionResult> GetCategoriesWithServices(CancellationToken cancellationToken)
        {
            var categories = await _categoryAppService.GetCategoriesWithServices(cancellationToken);
            return Ok(categories);
        }
    }

}
