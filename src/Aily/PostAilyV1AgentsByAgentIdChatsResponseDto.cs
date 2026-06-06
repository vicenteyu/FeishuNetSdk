// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdChatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起智能体会话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 发起智能体会话 响应体
/// <para>异步发起一轮智能体会话，提交用户消息后立即返回对话ID，触发智能体在后台运行。</para>
/// <para>接口ID：7646811253679819955</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdChatsResponseDto
{
    /// <summary>
    /// <para>对话ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7640186506971926032</para>
    /// </summary>
    [JsonPropertyName("agent_chat_id")]
    public string AgentChatId { get; set; } = string.Empty;
}
