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
/// <para>查询指定消息是否已读。接口只返回已读用户的信息，不返回未读用户的信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability) 。</para>
/// <para>- 查询消息已读信息时，机器人需要在待查询消息所在的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 只能查询由当前机器人自己发送的、发送时间不超过 7 天的消息已读信息。</para>
/// <para>- 一次请求只能查询一条消息，不支持批量查询。</para>
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
        /// <para>用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_9b851f7b51a9d58d109982337c46f3de</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>已读消息的时间，毫秒级时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1609484183000</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = string.Empty;

        /// <summary>
        /// <para>租户唯一标识。该标识用来识别租户，也可以用来获取租户访问凭证（tenant_access_token）。</para>
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
