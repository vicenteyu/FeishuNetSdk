// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="PatchApplicationV6ApplicationsByAppIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用分组信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用分组信息 请求体
/// <para>更新应用的分组信息（分组会影响应用在工作台中的分类情况，请谨慎更新）</para>
/// <para>接口ID：6989432329400270849</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdBodyDto
{
    /// <summary>
    /// <para>应用分类的国际化描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：["办公效率"]</para>
    /// <para>最大长度：3</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("common_categories")]
    public string[]? CommonCategories { get; set; }

    /// <summary>
    /// <para>是否允许刷新user_access_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("allow_refresh_token")]
    public bool? AllowRefreshToken { get; set; }

    /// <summary>
    /// <para>应用回调配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("callback_info")]
    public CallbackInfoSuffix? CallbackInfo { get; set; }

    /// <summary>
    /// <para>应用回调配置</para>
    /// </summary>
    public record CallbackInfoSuffix
    {
        /// <summary>
        /// <para>回调类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：webhook</para>
        /// <para>可选值：<list type="bullet">
        /// <item>webhook：将回调发送至开发者服务器</item>
        /// <item>websocket：使用长连接接收回调</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("callback_type")]
        public string? CallbackType { get; set; }

        /// <summary>
        /// <para>回调地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// </summary>
        [JsonPropertyName("request_url")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// <para>订阅的回调列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("subscribed_callbacks")]
        public string[]? SubscribedCallbacks { get; set; }
    }
}
