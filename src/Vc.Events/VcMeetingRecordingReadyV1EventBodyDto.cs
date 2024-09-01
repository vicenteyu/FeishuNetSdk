// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcMeetingRecordingReadyV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>录制完成 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 录制完成 事件体
/// <para>发生在录制文件上传完毕时【仅通过Open API预约的会议会产生此类事件】{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=meeting&amp;event=recording_ready)</para>
/// <para>接口ID：6960861158128959491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/events/recording_ready</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fevents%2frecording_ready</para>
/// </summary>
public record VcMeetingRecordingReadyV1EventBodyDto() : EventBodyDto("vc.meeting.recording_ready_v1")
{
    /// <summary>
    /// <para>会议数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting")]
    public MeetingEventMeeting? Meeting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record MeetingEventMeeting
    {
        /// <summary>
        /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会议主题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// <para>9位会议号（飞书用户可通过输入9位会议号快捷入会）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议拥有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public MeetingEventUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record MeetingEventUser
        {
            /// <summary>
            /// <para>用户 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public UserIdSuffix? Id { get; set; }
        }
    }

    /// <summary>
    /// <para>会议录制链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// <para>录制总时长（单位msec）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
