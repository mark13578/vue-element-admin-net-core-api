namespace JMWebAPI.Common.result
{
    /// <summary>
    /// Unified Response Structure
    /// </summary>
    public class Result<T>
    {
        /// <summary>
        /// Response Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Data Object
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Msg { get; set; }

        public static Result<T> Success()
        {
            return Success(default(T));
        }

        public static Result<T> Success(T data)
        {
            return new Result<T>
            {
                Code = "SUCCESS",
                Msg = "Operation Successful",
                Data = data
            };
        }

        public static Result<T> Failed()
        {
            return Result("ERROR", "System Execution Error", default(T));
        }

        public static Result<T> Failed(string msg)
        {
            return Result("ERROR", msg, default(T));
        }

        public static Result<T> Judge(bool status)
        {
            return status ? Success() : Failed();
        }

        private static Result<T> Result(string code, string msg, T data)
        {
            return new Result<T>
            {
                Code = code,
                Msg = msg,
                Data = data
            };
        }

        public static bool IsSuccess(Result<T> result)
        {
            return result != null && result.Code == "SUCCESS";
        }
    }

}
