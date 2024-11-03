// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdLinkResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群分享链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群分享链接 响应体
/// <para>获取指定群的分享链接，他人点击分享链接后可加入群组。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 调用该接口的用户或机器人必须在对应群组内。</para>
/// <para>- 单聊、密聊、团队群不支持生成分享链接。</para>
/// <para>- 当机器人被停用或者退出群组时，由该机器人获取的群分享链接也将失效。</para>
/// <para>- 当群组设置了 **仅群主和群管理员可添加群成员或分享群** 时，调用该接口的用户或机器人必须是群组的群主或管理员。</para>
/// <para>- 获取内部群分享链接时，调用该接口的用户或机器人必须和群组属于同一租户。</para>
/// <para>接口ID：7139929321426386972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/link</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flink</para>
/// </summary>
public record PostImV1ChatsByChatIdLinkResponseDto
{
    /// <summary>
    /// <para>群分享链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://applink.feishu.cn/client/chat/chatter/add_by_link?link_token=3nf8789-4rfx-427d-a6bf-ed1d2df348aabd</para>
    /// </summary>
    [JsonPropertyName("share_link")]
    public string? ShareLink { get; set; }

    /// <summary>
    /// <para>分享链接的过期时间，秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("expire_time")]
    public string? ExpireTime { get; set; }

    /// <summary>
    /// <para>分享链接是否永久有效</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_permanent")]
    public bool? IsPermanent { get; set; }
}
