// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHelpdeskV1StartServiceResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建服务台对话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建服务台对话 响应体
/// <para>该接口用于创建服务台对话。</para>
/// <para>接口ID：6955768699895726082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/start_service</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fstart_service</para>
/// </summary>
public record PostHelpdeskV1StartServiceResponseDto
{
    /// <summary>
    /// <para>客服群open ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：创建的chat-id</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; } = string.Empty;
}
