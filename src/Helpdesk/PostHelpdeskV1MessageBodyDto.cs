// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHelpdeskV1MessageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>服务台机器人向工单绑定的群内发送消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 服务台机器人向工单绑定的群内发送消息 请求体
/// <para>通过服务台机器人给指定用户的服务台专属群或私聊发送消息，支持文本、富文本、卡片、图片。</para>
/// <para>接口ID：7036209421748764675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fbot-message%2fcreate</para>
/// </summary>
public record PostHelpdeskV1MessageBodyDto
{
    /// <summary>
    /// <para>消息类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：post</para>
    /// <para>可选值：<list type="bullet">
    /// <item>text：普通文本</item>
    /// <item>post：富文本</item>
    /// <item>image：图片</item>
    /// <item>interactive：卡片消息</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，json格式结构序列化成string。格式说明参考: [发送消息content说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"post\":{\"zh_cn\":{\"title\":\"sometitle\",\"content\":[[{\"tag\":\"text\",\"text\":\"somecontent\"}]]}}}</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>接收消息用户id</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7346484524</para>
    /// </summary>
    [JsonPropertyName("receiver_id")]
    public string ReceiverId { get; set; } = string.Empty;

    /// <summary>
    /// <para>接收消息方式，chat(服务台专属服务群)或user(服务台机器人私聊)。若选择专属服务群，用户有正在处理的工单将会发送失败。默认以chat方式发送。</para>
    /// <para>必填：否</para>
    /// <para>示例值：chat</para>
    /// <para>可选值：<list type="bullet">
    /// <item>chat：通过服务台专属群发送</item>
    /// <item>user：通过服务台机器人私聊发送</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("receive_type")]
    public string? ReceiveType { get; set; }
}
