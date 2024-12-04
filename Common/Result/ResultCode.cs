//namespace JMWebAPI.Common.Result
//{
//    public class ResultCode
//    {
//    }
//}

using System;
using System.Collections.Generic;

namespace JMWebAPI.Common.Result
{
    /// <summary>
    /// 响应码枚举
    /// <para>参考阿里巴巴开发手册响应码规范</para>
    /// </summary>
    public class ResultCode : IResultCode
    {
        public string Code { get; private set; }
        public string Message { get; private set; }

        private ResultCode(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public static readonly ResultCode SUCCESS = new("00000", "一切ok");

        public static readonly ResultCode USER_ERROR = new("A0001", "用户端错误");
        public static readonly ResultCode REPEAT_SUBMIT_ERROR = new("A0002", "您的请求已提交，请不要重复提交或稍候再试。");
        
        public static readonly ResultCode USER_LOGIN_ERROR = new("A0200", "用户登录异常");
        
        public static readonly ResultCode USER_NOT_EXIST = new("A0201", "用户不存在");
        public static readonly ResultCode USER_ACCOUNT_LOCKED = new("A0202", "用户账户被冻结");
        public static readonly ResultCode USER_ACCOUNT_INVALID = new("A0203", "用户账户已作废"); 
        
        public static readonly ResultCode USERNAME_OR_PASSWORD_ERROR = new("A0210", "用户名或密码错误");
        public static readonly ResultCode PASSWORD_ENTER_EXCEED_LIMIT = new("A0211", "用户输入密码次数超限，请不要重复提交或稍候再试。");
        public static readonly ResultCode CLIENT_AUTHENTICATION_FAILED = new("A0212", "客户端认证失败");

        public static readonly ResultCode VERIFY_CODE_TIMEOUT = new("A0213", "验证码已过期");
        public static readonly ResultCode VERIFY_CODE_ERROR = new("A0214", "验证码错误");

        public static readonly ResultCode TOKEN_INVALID = new("A0230", "token无效或已过期"); 
        public static readonly ResultCode TOKEN_ACCESS_FORBIDDEN = new("A0231", "token已被禁止访问");
        
        public static readonly ResultCode AUTHORIZED_ERROR = new("A0300", "访问权限异常");
        public static readonly ResultCode ACCESS_UNAUTHORIZED = new("A0301", "访问未授权");
        public static readonly ResultCode FORBIDDEN_OPERATION = new("A0302", "演示环境禁止新增、修改和删除数据，请本地部署后测试");
        
        public static readonly ResultCode PARAM_ERROR = new("A0400", "用户请求参数错误");
        public static readonly ResultCode RESOURCE_NOT_FOUND = new("A0401", "请求资源不存在"); 
        public static readonly ResultCode PARAM_IS_NULL = new("A0410", "请求必填参数为空");
        
        public static readonly ResultCode USER_UPLOAD_FILE_ERROR = new("A0700", "用户上传文件异常");
        public static readonly ResultCode USER_UPLOAD_FILE_TYPE_NOT_MATCH = new("A0701", "用户上传文件类型不匹配");
        public static readonly ResultCode USER_UPLOAD_FILE_SIZE_EXCEEDS = new("A0702", "用户上传文件太大");
        public static readonly ResultCode USER_UPLOAD_IMAGE_SIZE_EXCEEDS = new("A0703", "用户上传图片太大");

        public static readonly ResultCode SYSTEM_EXECUTION_ERROR = new("B0001", "系统执行出错"); 
        public static readonly ResultCode SYSTEM_EXECUTION_TIMEOUT = new("B0100", "系统执行超时");
        public static readonly ResultCode SYSTEM_ORDER_PROCESSING_TIMEOUT = new("B0100", "系统订单处理超时");

        public static readonly ResultCode SYSTEM_DISASTER_RECOVERY_TRIGGER = new("B0200", "系统容灾功能被出发");
        public static readonly ResultCode FLOW_LIMITING = new("B0210", "系统限流");
        public static readonly ResultCode DEGRADATION = new("B0220", "系统功能降级");

        public static readonly ResultCode SYSTEM_RESOURCE_ERROR = new("B0300", "系统资源异常");
        public static readonly ResultCode SYSTEM_RESOURCE_EXHAUSTION = new("B0310", "系统资源耗尽");
        public static readonly ResultCode SYSTEM_RESOURCE_ACCESS_ERROR = new("B0320", "系统资源访问异常");
        public static readonly ResultCode SYSTEM_READ_DISK_FILE_ERROR = new("B0321", "系统读取磁盘文件失败");

        public static readonly ResultCode CALL_THIRD_PARTY_SERVICE_ERROR = new("C0001", "调用第三方服务出错");
        public static readonly ResultCode MIDDLEWARE_SERVICE_ERROR = new("C0100", "中间件服务出错");
        public static readonly ResultCode INTERFACE_NOT_EXIST = new("C0113", "接口不存在");

        public static readonly ResultCode MESSAGE_SERVICE_ERROR = new("C0120", "消息服务出错");
        public static readonly ResultCode MESSAGE_DELIVERY_ERROR = new("C0121", "消息投递出错");
        public static readonly ResultCode MESSAGE_CONSUMPTION_ERROR = new("C0122", "消息消费出错");
        public static readonly ResultCode MESSAGE_SUBSCRIPTION_ERROR = new("C0123", "消息订阅出错");
        public static readonly ResultCode MESSAGE_GROUP_NOT_FOUND = new("C0124", "消息分组未查到");

        public static readonly ResultCode DATABASE_ERROR = new("C0300", "数据库服务出错");
        public static readonly ResultCode DATABASE_TABLE_NOT_EXIST = new("C0311", "表不存在");
        public static readonly ResultCode DATABASE_COLUMN_NOT_EXIST = new("C0312", "列不存在");
        public static readonly ResultCode DATABASE_DUPLICATE_COLUMN_NAME = new("C0321", "多表关联中存在多个相同名称的列");
        public static readonly ResultCode DATABASE_DEADLOCK = new("C0331", "数据库死锁");
        public static readonly ResultCode DATABASE_PRIMARY_KEY_CONFLICT = new("C0341", "主键冲突");
        // Add other result codes similarly...

        public static ResultCode GetValue(string code)
        {
            foreach (var value in AllValues())
            {
                if (value.Code == code)
                {
                    return value;
                }
            }
            return ResultCode; // Default system execution error
        }

        public override string ToString()
        {
            return $"{{ \"code\": \"{Code}\", \"msg\": \"{Message}\" }}";
        }

        public static IEnumerable<ResultCode> AllValues()
        {
            yield return SUCCESS;
            yield return USER_ERROR;
            yield return REPEAT_SUBMIT_ERROR;
            yield return USER_LOGIN_ERROR;
            yield return USER_NOT_EXIST;
            yield return USER_ACCOUNT_LOCKED;
            yield return USER_ACCOUNT_INVALID;
            // Add other result codes similarly...
        }

       
    }

   
}

