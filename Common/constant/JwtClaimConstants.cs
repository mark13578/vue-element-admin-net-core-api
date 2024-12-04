//namespace JMWebAPI.Common.constant
//{
//    public class JwtClaimConstant
//    {
//    }
//}

namespace JMWebAPI.Common.Constant
{
    /// <summary>
    /// JWT Claims声明常量
    /// JWT Claims 属于 Payload 的一部分，包含了一些实体（通常指的用户）的状态和额外的元数据。
    /// </summary>
    public static class JwtClaimConstants
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public const string USER_ID = "userId";

        /// <summary>
        /// 部门ID
        /// </summary>
        public const string DEPT_ID = "deptId";

        /// <summary>
        /// 数据权限
        /// </summary>
        public const string DATA_SCOPE = "dataScope";

        /// <summary>
        /// 权限(角色Code)集合
        /// </summary>
        public const string AUTHORITIES = "authorities";
    }
}
