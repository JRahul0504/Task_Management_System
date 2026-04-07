using Microsoft.AspNetCore.Mvc;
using Task_Management_System.DTOs;
using Task_Management_System.Models;
using Task_Management_System.Repositories;
using Task_Management_System.Services;

namespace Task_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly JwtService _jwt;
        private readonly PasswordService _password;

        public AuthController(IUserRepository userRepo, JwtService jwt, PasswordService password)
        {
            _userRepo = userRepo;
            _jwt = jwt;
            _password = password;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                PasswordHash = _password.HashPassword(dto.Password),
                Role = "User"
            };

            await _userRepo.AddUser(user);
            return Ok("User Registered Successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _userRepo.GetUser(dto.Username);

            if (user == null ||
                user.PasswordHash != _password.HashPassword(dto.Password))
                return Unauthorized();

            var token = _jwt.GenerateToken(user);
            return Ok(new { token });
        }
    }
}
