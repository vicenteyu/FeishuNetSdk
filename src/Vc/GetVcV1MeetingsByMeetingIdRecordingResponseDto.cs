// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1MeetingsByMeetingIdRecordingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取录制文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取录制文件 响应体
/// <para>获取一个会议的录制文件。</para>
/// <para>## 注意事项</para>
/// <para>- 会议结束后并且收到了[录制完成](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/events/recording_ready)的事件方可获取录制文件。</para>
/// <para>- 请求头 Authorization 参数不同 Token 说明：</para>
/// <para>- 使用 user_access_token 时，只有会议归属人有权限获取录制文件。会议归属人是指[预约会议](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/apply)时，请求参数传入的归属人（owner_id）。</para>
/// <para>- 使用 tenant_access_token 时，可获取租户范围下的录制文件。</para>
/// <para>- 录制时间太短（小于 5s）有可能无法生成录制文件。</para>
/// <para>接口ID：6960861158593101828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fget</para>
/// </summary>
public record GetVcV1MeetingsByMeetingIdRecordingResponseDto
{
    /// <summary>
    /// <para>录制文件数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("recording")]
    public MeetingRecording? Recording { get; set; }

    /// <summary>
    /// <para>录制文件数据</para>
    /// </summary>
    public record MeetingRecording
    {
        /// <summary>
        /// <para>录制文件URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://meetings.feishu.cn/minutes/obcn37dxcftoc3656rgyejm7</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>录制总时长（单位msec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：30000</para>
        /// </summary>
        [JsonPropertyName("duration")]
        public string? Duration { get; set; }
    }
}
