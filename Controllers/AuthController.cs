using JMWebAPI.Common.result;
using JMWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using JMWebAPI.Enums;
using JMWebAPI.Services;
using JMWebAPI.Models.DTO;

namespace JMWebAPI.Controllers
{
    /// <summary>
    /// Authentication Controller
    /// </summary>
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Login result</returns>
        [HttpPost("login")]
        public IActionResult Login([FromForm, Required] string username, [FromForm, Required] string password)
        {
            _logger.LogInformation("User {Username} attempting to log in", username);
            var loginResult = _authService.Login(username, password);
            if (loginResult == null)
            {
                return Unauthorized("Invalid username or password");
            }
            return Ok(Result<LoginResult>.Success(loginResult));
        }

        /// <summary>
        /// Logout
        /// </summary>
        [HttpDelete("logout")]
        public IActionResult Logout()
        {
            _logger.LogInformation("User attempting to log out");
            _authService.Logout();
            return Ok(Result.Success());
        }

        /// <summary>
        /// Get Captcha
        /// </summary>
        /// <returns>Captcha result</returns>
        [HttpGet("captcha")]
        public IActionResult GetCaptcha()
        {
            _logger.LogInformation("Generating captcha");
            var captcha = _authService.GetCaptcha();
            return Ok(Result<CaptchaResult>.Success(captcha));
        }
    }
}
