using Microsoft.AspNetCore.Mvc;
using ServicoApi.Models;
using ServicoApi.Services;

namespace ServicoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var validUser = _userService.ValidateUser(user.Email, user.Password);
            if (!validUser)
                return Unauthorized();

            // Lógica para gerar token JWT
            // ...

            return Ok(new { Token = "seu_token_jwt_aqui" });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            _userService.CreateUser(user);
            return Ok(user);
        }
    }
}