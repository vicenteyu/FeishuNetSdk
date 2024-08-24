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
/// <para>当发送的仅特定人可见的卡片消息已交互完成，可调用本接口删除该卡片。删除后将不会在对应设备上留下任何痕迹。</para>
/// <para>接口ID：6907569742384316418</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delete-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITOyYjLykjM24iM5IjN</para>
/// </summary>
public record PostEphemeralV1DeleteBodyDto
{
    /// <summary>
    /// <para>消息 ID。调用[发送仅特定人可见的消息卡片](https://open.feishu.cn/document/ukTMukTMukTM/uETOyYjLxkjM24SM5IjN)接口后，在返回结果中获取。</para>
    /// <para>**示例值**：om_5ad573a6411d72b8305fda3a9c15c70e</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;
}
