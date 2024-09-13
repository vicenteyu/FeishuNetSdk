// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="VcMeetingAllMeetingStartedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>企业会议开始 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 企业会议开始 事件体
/// <para>发生在会议开始时，包含企业内所有会议开始事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=meeting&amp;event=all_meeting_started)</para>
/// <para>接口ID：7180231958790783004</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/events/all_meeting_started</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fevents%2fall_meeting_started</para>
/// </summary>
public record VcMeetingAllMeetingStartedV1EventBodyDto() : EventBodyDto("vc.meeting.all_meeting_started_v1")
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
        /// <para>会议开始时间（unix时间，单位：秒）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>会议结束时间（unix时间，单位：秒）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>会议主持人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("host_user")]
        public MeetingEventUser? HostUser { get; set; }

        /// <summary>
        /// <para>会议拥有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public MeetingEventUser? Owner { get; set; }

        /// <summary>
        /// <para>日程实体的唯一标志</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("calendar_event_id")]
        public string? CalendarEventId { get; set; }

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
    /// <para>事件操作人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public MeetingEventUser? Operator { get; set; }

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

        /// <summary>
        /// <para>用户会中角色</para>
        /// <para>**可选值有**：</para>
        /// <para>1:普通参会人,2:主持人,3:联席主持人</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：普通参会人</item>
        /// <item>2：主持人</item>
        /// <item>3：联席主持人</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_role")]
        public int? UserRole { get; set; }

        /// <summary>
        /// <para>用户类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:飞书用户,2:rooms用户,3:文档用户,4:neo单品用户,5:neo单品游客用户,6:pstn用户,7:sip用户,8:sharebox用户,9:开放平台应用</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：飞书用户</item>
        /// <item>2：rooms用户</item>
        /// <item>3：文档用户</item>
        /// <item>4：neo单品用户</item>
        /// <item>5：neo单品游客用户</item>
        /// <item>6：pstn用户</item>
        /// <item>7：sip用户</item>
        /// <item>8：sharebox用户</item>
        /// <item>9：开放平台应用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }
    }
}
