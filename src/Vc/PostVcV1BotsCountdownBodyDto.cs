// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="PostVcV1BotsCountdownBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会中倒计时 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 会中倒计时 请求体
/// <para>该接口用于会中操作倒计时，支持自定义时长、设置/延长/提前结束倒计时、关闭倒计时窗口。适用于会议控场场景</para>
/// <para>接口ID：7680486345160821966</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/countdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fcountdown</para>
/// </summary>
public record PostVcV1BotsCountdownBodyDto
{
    /// <summary>
    /// <para>会议唯一标识，必须传入长数字 meeting_id，不是 9 位会议号。可通过创建会议接口或会议列表查询接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7628568141510692381</para>
    /// </summary>
    [JsonPropertyName("meeting_id")]
    public string MeetingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>倒计时操作类型。可选值：set、prolong、end_in_advance、close_window。set 表示设置倒计时，prolong 表示延长倒计时，end_in_advance 表示提前结束，close_window 表示关闭会中倒计时窗口。</para>
    /// <para>必填：是</para>
    /// <para>示例值：set</para>
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// <para>倒计时时长，单位为分钟。action 为 set 或 prolong 时必填；set 时超过 24 小时会报错，prolong 时超过 24 小时会按 24 小时处理。</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// <para>倒计时结束时是否播放提示音。仅 action=set 时生效。默认为false。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_play_audio_at_end")]
    public bool? NeedPlayAudioAtEnd { get; set; }

    /// <summary>
    /// <para>倒计时结束前的提醒时间，单位为分钟。仅 action=set 时生效；只支持设置一次提醒，且必须大于 0 并小于 duration。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("reminder_before_end")]
    public string? ReminderBeforeEnd { get; set; }
}
