//using System.ComponentModel.DataAnnotations;
//using System.Xml.Linq;

//namespace JMWebAPI.Common.Base
//{
//    public class BasePageQuery
//    {
//    }
//}

using System;
using System.ComponentModel.DataAnnotations;

namespace JMWebAPI.Common.Base
{
    /// <summary>
    /// Base Page Query Object
    /// </summary>
    public class BasePageQuery
    {
        /// <summary>
        /// Page Number
        /// </summary>
        [Required]
        [Display(Name = "Page Number")]
        public int PageNum { get; set; } = 1;

        /// <summary>
        /// Page Size
        /// </summary>
        [Required]
        [Display(Name = "Page Size")]
        public int PageSize { get; set; } = 10;
    }
}
