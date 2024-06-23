// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostEphemeralV1DeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除仅特定人可见的消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 删除仅特定人可见的消息卡片 请求体
/// <para>在群会话中删除仅指定用户可见的临时消息卡片。</para>
/// <para>临时卡片消息可以通过该接口进行显式删除，临时卡片消息删除后将不会在该设备上留下任何痕迹。</para>
/// <para>**权限说明** ：需要启用[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)；需要机器人在会话群里。</para>
/// <para>接口ID：6907569742384316418</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delete-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITOyYjLykjM24iM5IjN</para>
/// </summary>
public record PostEphemeralV1DeleteBodyDto
{
    /// <summary>
    /// <para>临时消息ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;
}
