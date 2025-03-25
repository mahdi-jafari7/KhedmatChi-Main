using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Customer.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccountAppService _accountappservice;

        public AuthController(IAccountAppService accountappservice)
        {
            _accountappservice = accountappservice;
        }

        
        /// <param name="registerDto">اطلاعات ثبت‌نام</param>
       
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var errors = await _accountappservice.Register(registerDto);

            if (errors.Count > 0)
                return BadRequest(errors); 

            return Ok(new { Message = "ثبت‌نام با موفقیت انجام شد." });
        }
    }
}
