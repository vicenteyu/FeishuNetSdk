// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV2FeedCardsByFeedCardIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>即时提醒 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 即时提醒 请求体
/// <para>即时提醒能力是飞书在消息列表中提供的强提醒能力，当有重要通知或任务需要及时触达用户，可将群组或机器人对话在消息列表中置顶展示，打开飞书首页即可处理重要任务。</para>
/// <para>接口ID：7291232621641039875</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/feed_card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fpatch</para>
/// </summary>
public record PatchImV2FeedCardsByFeedCardIdBodyDto
{
    /// <summary>
    /// <para>即时提醒状态，true-打开，false-关闭</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("time_sensitive")]
    public bool TimeSensitive { get; set; }

    /// <summary>
    /// <para>用户id 列表，支持OpenID，UnionID, UserID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();
}
