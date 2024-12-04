namespace JMWebAPI.Common.Result
{
    /// <summary>
    /// Response code interface
    /// </summary>
    public interface IResultCode
    {
        /// <summary>
        /// Gets the response code
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the response message
        /// </summary>
        string Message { get; }
    }
}
