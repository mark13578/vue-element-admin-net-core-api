using System.Text.Json.Serialization;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// Login Result Response Object
    /// </summary>
    public class LoginResult
    {
        /// <summary>
        /// Access Token
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Token Type (e.g., Bearer)
        /// </summary>
        [JsonPropertyName("tokenType")]
        public string TokenType { get; set; }

        /// <summary>
        /// Refresh Token
        /// </summary>
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Expiration Time (in milliseconds)
        /// </summary>
        [JsonPropertyName("expires")]
        public long Expires { get; set; }

        public LoginResult() { }

        public LoginResult(string accessToken, string tokenType, string refreshToken, long expires)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            RefreshToken = refreshToken;
            Expires = expires;
        }
    }
}
