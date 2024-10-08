// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="FeishuNetSdkOptions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>SDK配置</summary>
// ************************************************************************
namespace FeishuNetSdk
{
    /// <summary>
    /// SDK配置
    /// </summary>
    public class FeishuNetSdkOptions
    {
        /// <summary>
        /// 事件内容序列化鉴别器
        /// </summary>
        public const string Discriminator = "event_type";

        /// <summary>
        /// 应用Id
        /// </summary>
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 应用密钥
        /// </summary>
        public string AppSecret { get; set; } = string.Empty;

        /// <summary>
        /// 事件订阅 解密的密钥
        /// </summary>
        public string? EncryptKey { get; set; }

        /// <summary>
        /// 事件订阅 验证应用的密钥
        /// </summary>
        public string? VerificationToken { get; set; }

        /// <summary>
        /// 启用日志 （true = 启用， false = 关闭， 默认 = 启用）
        /// </summary>
        public bool EnableLogging { get; set; } = true;

        /// <summary>
        /// 忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）
        /// </summary>
        public bool IgnoreStatusException { get; set; } = true;
    }
}
