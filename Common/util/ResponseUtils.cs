using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JMWebAPI.Common.Util
{
    public static class ResponseUtils
    {
        private static readonly ILogger logger = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        }).CreateLogger("ResponseUtils");

        /// <summary>
        /// 异常消息返回 (适用于过滤器中处理异常响应)
        /// </summary>
        /// <param name="response">Http Response</param>
        /// <param name="resultCode">响应结果码</param>
        public static async Task WriteErrMsg(HttpResponse response, ResultCode resultCode)
        {
            // 根据不同的结果码设置 HTTP 状态
            int statusCode = resultCode switch
            {
                ResultCode.AccessUnauthorized or ResultCode.TokenInvalid => (int)HttpStatusCode.Unauthorized,
                ResultCode.TokenAccessForbidden => (int)HttpStatusCode.Forbidden,
                _ => (int)HttpStatusCode.BadRequest
            };

            response.StatusCode = statusCode;
            response.ContentType = "application/json";
            response.Headers["Charset"] = "utf-8";

            try
            {
                var jsonResponse = JsonConvert.SerializeObject(Result.Failed(resultCode));
                await using (var writer = new StreamWriter(response.Body, Encoding.UTF8))
                {
                    await writer.WriteAsync(jsonResponse);
                    await writer.FlushAsync(); // 确保将响应内容写入到输出流
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "响应异常处理失败");
            }
        }
    }

    public enum ResultCode
    {
        AccessUnauthorized,
        TokenInvalid,
        TokenAccessForbidden,
        BadRequest
    }

    public class Result
    {
        public static object Failed(ResultCode resultCode)
        {
            return new { Code = resultCode, Message = resultCode.ToString() };
        }
    }
}
