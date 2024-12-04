namespace JMWebAPI.Common.Constant
{
    /// <summary>
    /// 缓存常量
    /// </summary>
    public static class SecurityConstants
    {
        /// <summary>
        /// 验证码缓存前缀
        /// </summary>
        public const string CAPTCHA_CODE_PREFIX = "captcha_code:";

        /// <summary>
        /// 角色和权限缓存前缀
        /// </summary>
        public const string ROLE_PERMS_PREFIX = "role_perms:";

        /// <summary>
        /// 黑名单Token缓存前缀
        /// </summary>
        public const string BLACKLIST_TOKEN_PREFIX = "token:blacklist:";

        /// <summary>
        /// 登录路径
        /// </summary>
        public const string LOGIN_PATH = "/api/v1/auth/login";

        /// <summary>
        /// JWT Token 前缀
        /// </summary>
        public const string JWT_TOKEN_PREFIX = "Bearer ";
    }
}
