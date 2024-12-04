//namespace JMWebAPI.Common.result
//{
//    public class PageResult
//    {
//    }
//}

namespace JMWebAPI.Common.Result
{
    /// <summary>
    /// Page Result Structure
    /// </summary>
    public class PageResult<T>
    {
        /// <summary>
        /// Response Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Data Object
        /// </summary>
        public PageData<T> Data { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Msg { get; set; }

        public static PageResult<T> Success(IPage<T> page)
        {
            return new PageResult<T>
            {
                Code = "SUCCESS",
                Data = new PageData<T>
                {
                    List = page.Records,
                    Total = page.Total
                },
                Msg = "Operation Successful"
            };
        }
    }

    /// <summary>
    /// Page Data
    /// </summary>
    public class PageData<T>
    {
        /// <summary>
        /// List of Items
        /// </summary>
        public List<T> List { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public long Total { get; set; }
    }
}

