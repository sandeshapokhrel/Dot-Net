using DemoMvcApp.Repositories;
using DemoMvcApp.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUserRepository _userRepository;
        private readonly JwtTokenHelper _jwtTokenHelper;

        public AuthController(IUserRepository userRepository, JwtTokenHelper jwtTokenHelper)
        {
            _userRepository = userRepository;
            _jwtTokenHelper = jwtTokenHelper;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] DTOs.UserLoginDto loginDto)
        {
            var user = _userRepository.Authenticate(loginDto.Username, loginDto.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var token = _jwtTokenHelper.GenerateToken(user);
            return Ok(new { token });
        }

        [Authorize]
        [HttpGet("Secure-data")]
        public IActionResult GetSecureData()
        {
            return Ok("This is secure data");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin-data")]
        public IActionResult GetAdminData()
        {
            return Ok("Admin-only data");
        }

    }
}
