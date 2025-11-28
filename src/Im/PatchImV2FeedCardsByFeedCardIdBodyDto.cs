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
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fpatch</para>
/// </summary>
public record PatchImV2FeedCardsByFeedCardIdBodyDto
{
    /// <summary>
    /// <para>即时提醒状态（设置为 true 后，卡片在消息列表临时置顶；设置为 false，消息卡片不置顶）</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("time_sensitive")]
    public bool TimeSensitive { get; set; }

    /// <summary>
    /// <para>用户 ID 列表（ID 类型与 user_id_type 的取值一致。如果是商店应用，因不支持获取用户 user ID 权限，所以无法使用 user_id 类型的用户 ID）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];
}
