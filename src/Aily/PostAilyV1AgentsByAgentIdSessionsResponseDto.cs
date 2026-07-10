// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdSessionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建会话 响应体
/// <para>本接口用于智能体创建空白会话</para>
/// <para>接口ID：7657118382231555265</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdSessionsResponseDto
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
    /// <para>会话创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783424638072</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
}
