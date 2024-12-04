using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// User Export View Object
    /// </summary>
    public class UserExportDTO
    {
        /// <summary>
        /// Username
        /// </summary>
        [Display(Name = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Department Name
        /// </summary>
        [Display(Name = "Department")]
        public string DeptName { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Mobile Number
        /// </summary>
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [Display(Name = "Creation Time")]
        public DateTime CreateTime { get; set; }
    }
}
