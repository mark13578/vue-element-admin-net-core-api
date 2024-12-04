//namespace JMWebAPI.Models.DTO
//{
//    public class UserAuthInfo
//    {
//    }
//}

using System.Collections.Generic;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// User Authentication Information
    /// </summary>
    public class UserAuthInfo
    {
        /// <summary>
        /// User ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Department ID
        /// </summary>
        public long DeptId { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// User Status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Roles
        /// </summary>
        public HashSet<string> Roles { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        public HashSet<string> Perms { get; set; }

        /// <summary>
        /// Data Scope
        /// </summary>
        public int DataScope { get; set; }
    }
}

