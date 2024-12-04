

using System.Collections.Generic;

namespace JMWebAPI.Models.VO
{
    /// <summary>
    /// Current Logged-in User View Object
    /// </summary>
    public class UserInfoVO2
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
        /// Mobile
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// User Role Codes
        /// </summary>
        public HashSet<string> Roles { get; set; }

        /// <summary>
        /// User Permissions
        /// </summary>
        public HashSet<string> Perms { get; set; }
    }
}

