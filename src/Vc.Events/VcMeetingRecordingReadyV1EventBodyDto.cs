// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
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
        /// <para>会议创建源</para>
        /// <para>**可选值有**：</para>
        /// <para>1:日程会议,2:即时会议,3:面试会议,4:开放平台会议,100:其他会议类型</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：日程会议</item>
        /// <item>2：即时会议</item>
        /// <item>3：面试会议</item>
        /// <item>4：开放平台会议</item>
        /// <item>100：其他会议类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("meeting_source")]
        public int? MeetingSource { get; set; }

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

        /// <summary>
        /// <para>会议子类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:会前投屏,2:有线共享,3:会前妙享,4:企业办公电话,5:IP Phone,6:网络研讨会</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：会前投屏</item>
        /// <item>2：有线共享</item>
        /// <item>3：会前妙享</item>
        /// <item>4：企业办公电话</item>
        /// <item>5：IP Phone</item>
        /// <item>6：网络研讨会</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("meeting_sub_type")]
        public int? MeetingSubType { get; set; }

        /// <summary>
        /// <para>会议安全设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("security_setting")]
        public MeetingSecuritySetting? SecuritySetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record MeetingSecuritySetting
        {
            /// <summary>
            /// <para>安全级别</para>
            /// <para>**可选值有**：</para>
            /// <para>1:所有人可加入,2:仅企业内用户可加入,3:仅指定联系人和群可加入,4:仅主持人可参会（锁定会议）</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：所有人可加入</item>
            /// <item>2：仅企业内用户可加入</item>
            /// <item>3：仅指定联系人和群可加入</item>
            /// <item>4：仅主持人可参会（锁定会议）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("security_level")]
            public int? SecurityLevel { get; set; }

            /// <summary>
            /// <para>允许入会的群组ID列表</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `200`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("group_ids")]
            public string[]? GroupIds { get; set; }

            /// <summary>
            /// <para>允许入会的用户ID列表</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `200`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_ids")]
            public UserIdSuffix[]? UserIds { get; set; }

            /// <summary>
            /// <para>允许入会的会议室ID列表</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `200`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("room_ids")]
            public string[]? RoomIds { get; set; }

            /// <summary>
            /// <para>是否设置了仅指定联系人和群组可参会</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("has_set_security_contacts_and_group")]
            public bool? HasSetSecurityContactsAndGroup { get; set; }
        }

        /// <summary>
        /// <para>研讨会相关设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("webinar_setting")]
        public MeetingWebinarSetting? WebinarSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record MeetingWebinarSetting
        {
            /// <summary>
            /// <para>网络研讨会类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:普通网络研讨会,2:直播网络研讨会</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通网络研讨会</item>
            /// <item>2：直播网络研讨会</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("webinar_type")]
            public int? WebinarType { get; set; }
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
