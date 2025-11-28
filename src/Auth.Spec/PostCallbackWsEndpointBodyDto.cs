// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="PostCallbackWsEndpointBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取长连接地址 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec
{
    /// <summary>
    /// 获取长连接地址 请求体
    /// </summary>
    public record PostCallbackWsEndpointBodyDto
    {
        /// <summary>
        /// <para>应用唯一标识，创建应用后获得。有关`app_id` 的详细介绍。请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
        /// <para>**示例值：** "cli_slkdjalasdkjasd"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("AppID")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用秘钥，创建应用后获得。有关 `app_secret` 的详细介绍，请参考[通用参数](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology)介绍</para>
        /// <para>**示例值：** "dskLLdkasdjlasdKK"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("AppSecret")]
        public string AppSecret { get; set; } = string.Empty;
    }
}
