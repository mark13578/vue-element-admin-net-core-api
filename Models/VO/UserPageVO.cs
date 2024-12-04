//using System.Text.Json.Serialization;

//namespace JMWebAPI.Models.VO
//{
//    public class UserPageVO
//    {
//    }
//}

using System;
using System.Text.Json.Serialization;

namespace JMWebAPI.Models.VO
{
    /// <summary>
    /// User Page View Object
    /// </summary>
    public class UserPageVO
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Mobile
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// Gender Label
        /// </summary>
        [JsonPropertyName("genderLabel")]
        public string GenderLabel { get; set; }

        /// <summary>
        /// User Avatar URL
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// User Status (1 - Active, 0 - Disabled)
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Department Name
        /// </summary>
        [JsonPropertyName("deptName")]
        public string DeptName { get; set; }

        /// <summary>
        /// Role Names (comma separated)
        /// </summary>
        [JsonPropertyName("roleNames")]
        public string RoleNames { get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonPropertyName("createTime")]
        public DateTime CreateTime { get; set; }
    }
}
