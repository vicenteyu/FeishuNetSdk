// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHelpdeskV1MessageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>服务台机器人向工单绑定的群内发送消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 服务台机器人向工单绑定的群内发送消息 响应体
/// <para>通过服务台机器人给指定用户的服务台专属群或私聊发送消息，支持文本、富文本、卡片、图片。</para>
/// <para>接口ID：7036209421748764675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fbot-message%2fcreate</para>
/// </summary>
public record PostHelpdeskV1MessageResponseDto
{
    /// <summary>
    /// <para>chat消息open_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_7054301238434</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
