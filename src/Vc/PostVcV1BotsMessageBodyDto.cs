// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="PostVcV1BotsMessageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送会中消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 发送会中消息 请求体
/// <para>向指定的视频会议发送会中消息。</para>
/// <para>接口ID：7672664994766982391</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/message</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fmessage</para>
/// </summary>
public record PostVcV1BotsMessageBodyDto
{
    /// <summary>
    /// <para>会议唯一标识，必须传入长数字 meeting_id，不是 9 位会议号。可通过“获取用户活跃会议列表”等会议查询接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7628568141510692381</para>
    /// </summary>
    [JsonPropertyName("meeting_id")]
    public string MeetingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息类型。可选值：text、reaction。text 表示会中文本消息，reaction 表示会中反馈表情。</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容。当 msg_type=text 时表示文本内容；当 msg_type=reaction 时表示反馈表情 key。表情可选值参考：[表情参考说明](https://open.larkoffice.com/document/server-docs/vc-v1/bot/user-guide/meeting-emoji-reference)</para>
    /// <para>必填：是</para>
    /// <para>示例值：请大家看一下这个问题</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>幂等去重 ID，对应底层 Cid。不传时服务端自动生成并在响应中返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7f3b7fd2-1b64-4f5d-9e8b-2f2d8d3b0c11</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
