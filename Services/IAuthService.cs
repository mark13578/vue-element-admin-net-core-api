using JMWebAPI.Models.DTO;

namespace JMWebAPI.Services
{
    /// <summary>
    /// Authentication Service Interface
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>LoginResult</returns>
        LoginResult Login(string username, string password);

        /// <summary>
        /// Logout
        /// </summary>
        void Logout();

        /// <summary>
        /// Get Captcha
        /// </summary>
        /// <returns>CaptchaResult</returns>
        CaptchaResult GetCaptcha();
    }
}

