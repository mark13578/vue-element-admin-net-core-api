//using System.ComponentModel.DataAnnotations;

//namespace JMWebAPI.Models.Form
//{
//    public class UserForm
//    {
//    }
//}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JMWebAPI.Models.Form
{
    /// <summary>
    /// User Form Object
    /// </summary>
    public class UserForm
    {
        /// <summary>
        /// User ID
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [Required(ErrorMessage = "Username cannot be empty")]
        public string Username { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [Required(ErrorMessage = "Nickname cannot be empty")]
        public string Nickname { get; set; }

        /// <summary>
        /// Mobile Number
        /// </summary>
        [RegularExpression("^$|^1(3\\d|4[5-9]|5[0-35-9]|6[2567]|7[0-8]|8\\d|9[0-35-9])\\d{8}$", ErrorMessage = "Invalid mobile number format")]
        public string Mobile { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// User Avatar
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User Status (1 - Active, 0 - Disabled)
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Department ID
        /// </summary>
        public long? DeptId { get; set; }

        /// <summary>
        /// Role IDs
        /// </summary>
        [Required(ErrorMessage = "User roles cannot be empty")]
        public List<long> RoleIds { get; set; }
    }
}
