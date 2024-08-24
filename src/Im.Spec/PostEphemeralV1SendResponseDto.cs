// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostEphemeralV1SendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送仅特定人可见的消息卡片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 发送仅特定人可见的消息卡片 响应体
/// <para>调用该接口，可以使应用机器人在指定群聊中发送仅指定用户可见的卡片消息。卡片上将展示 **仅对你可见** 标识，如下图所示。</para>
/// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/b0ec0ce45942463381457edc7b62e144_RXYCFtfUtb.png?height=486&amp;lazyload=true&amp;maxWidth=592&amp;width=1592)</para>
/// <para>接口ID：6907569523177078785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/send-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETOyYjLxkjM24SM5IjN</para>
/// </summary>
public record PostEphemeralV1SendResponseDto
{
    /// <summary>
    /// <para>消息 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
