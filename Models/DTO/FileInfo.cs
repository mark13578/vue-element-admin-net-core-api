

using System.Text.Json.Serialization;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// 文件對象
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        /// 文件名稱
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件 URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}

