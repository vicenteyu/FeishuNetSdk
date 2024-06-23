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
/// <para>获取指定群的分享链接。</para>
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
    /// <para>分享链接过期时间戳（秒级）</para>
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
