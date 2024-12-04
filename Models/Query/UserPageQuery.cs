//using System.ComponentModel.DataAnnotations;
//using System.Xml.Linq;

//namespace JMWebAPI.Models.Query
//{
//    public class UserPageQuery
//    {
//    }
//}

using System;
using System.ComponentModel.DataAnnotations;
using JMWebAPI.Common.Base;

namespace JMWebAPI.Models.Query
{
    /// <summary>
    /// User Page Query Object
    /// </summary>
    public class UserPageQuery : BasePageQuery
    {
        /// <summary>
        /// Keywords (Username/Nickname/Mobile Number)
        /// </summary>
        [Display(Name = "Keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// User Status
        /// </summary>
        [Display(Name = "Status")]
        public int? Status { get; set; }

        /// <summary>
        /// Department ID
        /// </summary>
        [Display(Name = "Department ID")]
        public long? DeptId { get; set; }

        /// <summary>
        /// Start Time for Creation Date
        /// </summary>
        [Display(Name = "Start Time")]
        [DataType(DataType.Date)]
        public string StartTime { get; set; }

        /// <summary>
        /// End Time for Creation Date
        /// </summary>
        [Display(Name = "End Time")]
        [DataType(DataType.Date)]
        public string EndTime { get; set; }
    }
}

