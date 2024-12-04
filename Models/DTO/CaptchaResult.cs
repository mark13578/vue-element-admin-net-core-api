

using System.Text.Json.Serialization;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// Captcha Result Response Object
    /// </summary>
    public class CaptchaResult
    {
        /// <summary>
        /// Captcha ID
        /// </summary>
        [JsonPropertyName("captchaKey")]
        public string CaptchaKey { get; set; }

        /// <summary>
        /// Captcha Image Base64 String
        /// </summary>
        [JsonPropertyName("captchaBase64")]
        public string CaptchaBase64 { get; set; }

        public CaptchaResult() { }

        public CaptchaResult(string captchaKey, string captchaBase64)
        {
            CaptchaKey = captchaKey;
            CaptchaBase64 = captchaBase64;
        }
    }
}
