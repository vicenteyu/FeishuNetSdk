// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHelpdeskV1AgentEmailsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取客服邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 获取客服邮箱 响应体
/// <para>该接口用于获取客服邮箱地址。</para>
/// <para>接口ID：6955768425688399875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent/agent_email</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent%2fagent_email</para>
/// </summary>
public record GetHelpdeskV1AgentEmailsResponseDto
{
    /// <summary>
    /// <para>agent emails</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"ou_xxx\":\"xxx\",\"ou_yyy\":\"yyy\"}</para>
    /// </summary>
    [JsonPropertyName("agents")]
    public Dictionary<string, string>? Agents { get; set; }
}
