using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JMWebAPI.Services;
using JMWebAPI.Models.DTO;

namespace YourNamespace.Controllers
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
        /// <returns>LoginResult</returns>
        [HttpPost("login")]
        public ActionResult<LoginResult> Login([FromQuery] string username, [FromQuery] string password)
        {
            _logger.LogInformation("User login attempt: {Username}", username);
            var loginResult = _authService.Login(username, password);
            return Ok(new ApiResponse<LoginResult>(loginResult));
        }

        /// <summary>
        /// Logout
        /// </summary>
        [HttpDelete("logout")]
        public ActionResult Logout()
        {
            _logger.LogInformation("User logout");
            _authService.Logout();
            return Ok(new ApiResponse());
        }

        /// <summary>
        /// Get Captcha
        /// </summary>
        /// <returns>CaptchaResult</returns>
        [HttpGet("captcha")]
        public ActionResult<CaptchaResult> GetCaptcha()
        {
            _logger.LogInformation("Getting captcha");
            var captcha = _authService.GetCaptcha();
            return Ok(new ApiResponse<CaptchaResult>(captcha));
        }
    }
}
