// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="GetAilyV1AgentsByAgentIdSessionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会话列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 查询会话列表 响应体
/// <para>本接口用于查询智能体的会话列表。</para>
/// <para>接口ID：7657118382231506113</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2flist</para>
/// </summary>
public record GetAilyV1AgentsByAgentIdSessionsResponseDto : IPageableResponse<GetAilyV1AgentsByAgentIdSessionsResponseDto.AgentChatSession>
{
    /// <summary>
    /// 会话列表
    /// </summary>
    public AgentChatSession[]? Items => Sessions;

    /// <summary>
    /// <para>会话列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sessions")]
    public AgentChatSession[]? Sessions { get; set; }

    /// <summary>
    /// <para>会话列表</para>
    /// </summary>
    public record AgentChatSession
    {
        /// <summary>
        /// <para>会话ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：conversation_sadcadcds2</para>
        /// <para>最大长度：65</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话名</para>
        /// <para>必填：否</para>
        /// <para>示例值：question</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>会话状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：done</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783428305028</para>
        /// <para>最大值：91783428305028</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// <para>最后一次对话时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783428305028</para>
        /// <para>最大值：91783428305028</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("last_chat_at")]
        public double? LastChatAt { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>下一页的token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783425184259422</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// 下一页的token
    /// </summary>
    public string? PageToken => NextPageToken;
}
