// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="GetAilyV1AgentsByAgentIdChatsByAgentChatIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取对话结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 获取对话结果 响应体
/// <para>本接口用于获取智能体的对话回复，内容包括文字和产物等信息。</para>
/// <para>接口ID：7646811253679803571</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat%2fget</para>
/// </summary>
public record GetAilyV1AgentsByAgentIdChatsByAgentChatIdResponseDto
{
    /// <summary>
    /// <para>Agent回复内容</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("content")]
    public AgentChatMessage[] Contents { get; set; } = [];

    /// <summary>
    /// <para>Agent回复内容</para>
    /// </summary>
    public record AgentChatMessage
    {
        /// <summary>
        /// <para>类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：text</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>文本内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：你好，我是你的专属智能体，请问有什么可以帮你？</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// <para>产物id</para>
        /// <para>必填：否</para>
        /// <para>示例值：3d058789-6952-4697-bf9c-1add1ebc206e</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("agent_artifact_id")]
        public string? AgentArtifactId { get; set; }

        /// <summary>
        /// <para>产物类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：sandbox_file</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("artifact_type")]
        public string? ArtifactType { get; set; }
    }

    /// <summary>
    /// <para>对话结束原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：stop</para>
    /// </summary>
    [JsonPropertyName("finish_reason")]
    public string? FinishReason { get; set; }

    /// <summary>
    /// <para>状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：Cancelled</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}
