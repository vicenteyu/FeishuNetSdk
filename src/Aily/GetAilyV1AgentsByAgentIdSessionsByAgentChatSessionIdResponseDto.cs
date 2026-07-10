// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="GetAilyV1AgentsByAgentIdSessionsByAgentChatSessionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指定会话信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 获取指定会话信息 响应体
/// <para>本接口用于查询智能体某次指定会话的详细信息。</para>
/// <para>接口ID：7657118382231522497</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2fget</para>
/// </summary>
public record GetAilyV1AgentsByAgentIdSessionsByAgentChatSessionIdResponseDto
{
    /// <summary>
    /// <para>会话ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：conversation_4kj6xxrp2jqk2</para>
    /// </summary>
    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    /// <summary>
    /// <para>会话名</para>
    /// <para>必填：否</para>
    /// <para>示例值：新会话</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>会话状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：opening</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>会话创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783424638072</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// <para>会话上次对话时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783424638072</para>
    /// </summary>
    [JsonPropertyName("last_chat_at")]
    public string? LastChatAt { get; set; }

    /// <summary>
    /// <para>会话的对话轮次</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("turns")]
    public AgentChatTurn? Turns { get; set; }

    /// <summary>
    /// <para>会话的对话轮次</para>
    /// </summary>
    public record AgentChatTurn
    {
        /// <summary>
        /// <para>智能体对话ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7659751102812343833</para>
        /// <para>最大长度：65</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("agent_chat_id")]
        public string? AgentChatId { get; set; }

        /// <summary>
        /// <para>对话创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783425174260</para>
        /// <para>最大值：91783425174260</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// <para>对话状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：Completed</para>
        /// <para>最大长度：65</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
