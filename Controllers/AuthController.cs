using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PatikaTask.DTOs.AuthDTOs;
using PatikaTask.Services;

namespace PatikaTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        [AllowAnonymous] 
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_jwtService.ValidateCredentials(request.Email, request.Password))
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }

            var token = _jwtService.GenerateToken(request.Email);
            var response = new LoginResponse
            {
                Token = token,
                ExpiresAt = DateTime.UtcNow.AddMinutes(60),
                Message = "Login successful"
            };

            return Ok(response);
        }
    }
}