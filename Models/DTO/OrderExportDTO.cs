

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace YourNamespace.Models.DTO
{
    /// <summary>
    /// 用戶導出視圖對象
    /// </summary>
    public class OrderExportDTO
    {
        [JsonPropertyName("docDate")]
        [Display(Name = "接件日期")]
        public string DocDate { get; set; }

        [JsonPropertyName("docNum")]
        [Display(Name = "接件編號")]
        public string DocNum { get; set; }

        [JsonPropertyName("customerName")]
        [Display(Name = "客戶名稱")]
        public string CustomerName { get; set; }

        [JsonPropertyName("caseName")]
        [Display(Name = "案件名稱")]
        public string CaseName { get; set; }
    }
}
