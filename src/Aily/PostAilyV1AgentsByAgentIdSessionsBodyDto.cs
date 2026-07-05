// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdSessionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建会话 请求体
/// <para>本接口用于智能体创建空白会话</para>
/// <para>接口ID：7657118382231555265</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdSessionsBodyDto
{
    /// <summary>
    /// <para>会话名</para>
    /// <para>必填：否</para>
    /// <para>示例值：计算问题</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
