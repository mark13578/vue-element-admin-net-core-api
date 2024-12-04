using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// 用戶導入數據傳輸對象
    /// </summary>
    public class UserImportDTO
    {
        [JsonPropertyName("username")]
        [Display(Name = "用户名")]
        public string Username { get; set; }

        [JsonPropertyName("nickname")]
        [Display(Name = "昵称")]
        public string Nickname { get; set; }

        [JsonPropertyName("genderLabel")]
        [Display(Name = "性别")]
        public string GenderLabel { get; set; }

        [JsonPropertyName("mobile")]
        [Display(Name = "手机号码")]
        public string Mobile { get; set; }

        [JsonPropertyName("email")]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        [JsonPropertyName("roleCodes")]
        [Display(Name = "角色")]
        public string RoleCodes { get; set; }

        [JsonPropertyName("deptCode")]
        [Display(Name = "部门")]
        public string DeptCode { get; set; }
    }
}
