// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1MessagesByMessageIdReadUsersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询消息已读信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 查询消息已读信息 响应体
/// <para>查询消息的已读信息。</para>
/// <para>接口ID：6946222929790386204</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/read_users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fread_users</para>
/// </summary>
public record GetImV1MessagesByMessageIdReadUsersResponseDto
{
    /// <summary>
    /// <para>-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ReadUser[]? Items { get; set; }

    /// <summary>
    /// <para>-</para>
    /// </summary>
    public record ReadUser
    {
        /// <summary>
        /// <para>用户id类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：open_id</para>
        /// </summary>
        [JsonPropertyName("user_id_type")]
        public string UserIdType { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户id</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_9b851f7b51a9d58d109982337c46f3de</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>阅读时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1609484183000</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = string.Empty;

        /// <summary>
        /// <para>tenant key</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhUPhXQDvtrQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
