// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcMeetingLeaveMeetingV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离开会议 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 离开会议 事件体
/// <para>发生在有人离开会议时【仅通过Open API预约的会议会产生此类事件】{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=meeting&amp;event=leave_meeting)</para>
/// <para>接口ID：6960861158128975875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/events/leave_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fevents%2fleave_meeting</para>
/// </summary>
public record VcMeetingLeaveMeetingV1EventBodyDto() : EventBodyDto("vc.meeting.leave_meeting_v1")
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
        /// <para>会议结束时间（unix时间，单位：秒）</para>
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
        /// <para>1:飞书用户,2:rooms用户,3:文档用户,4:neo单品用户,5:neo单品游客用户,6:pstn用户,7:sip用户</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：飞书用户</item>
        /// <item>2：rooms用户</item>
        /// <item>3：文档用户</item>
        /// <item>4：neo单品用户</item>
        /// <item>5：neo单品游客用户</item>
        /// <item>6：pstn用户</item>
        /// <item>7：sip用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }
    }


    /// <summary>
    /// <para>离开会议原因</para>
    /// <para>**可选值有**：</para>
    /// <para>1:主动离会,2:会议结束,3:被踢出</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：主动离会</item>
    /// <item>2：会议结束</item>
    /// <item>3：被踢出</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("leave_reason")]
    public int? LeaveReason { get; set; }
}
