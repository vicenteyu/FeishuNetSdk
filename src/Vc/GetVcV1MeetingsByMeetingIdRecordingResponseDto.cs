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
