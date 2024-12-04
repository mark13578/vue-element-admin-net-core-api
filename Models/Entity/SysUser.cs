using System;
using JMWebAPI.Common.Base;

namespace JMWebAPI.Models.Entity
{
    /// <summary>
    /// System User Entity
    /// </summary>
    public class SysUser : BaseEntity
    {
        /// <summary>
        /// User ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gender (1 - Male, 2 - Female, 0 - Secret)
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Department ID
        /// </summary>
        public long DeptId { get; set; }

        /// <summary>
        /// User Avatar
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Mobile
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Status (1 - Active, 0 - Disabled)
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Created By User ID
        /// </summary>
        public long? CreateBy { get; set; }

        /// <summary>
        /// Updated By User ID
        /// </summary>
        public long? UpdateBy { get; set; }
    }
}
