// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="VcBotMeetingInvitedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>邀请机器人入会 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 邀请机器人入会 事件体
/// <para>当用户邀请机器人加入会议时，系统会向订阅方推送此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=bot&amp;event=meeting_invited)</para>
/// <para>接口ID：7672664994766949623</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_invited</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_invited</para>
/// </summary>
public record VcBotMeetingInvitedV1EventBodyDto() : EventBodyDto("vc.bot.meeting_invited_v1")
{
    /// <summary>
    /// 
    /// </summary>
    public record MeetingAgentEventUser
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public UserIdSuffix? Id { get; set; }

        /// <summary>
        /// <para>用户类型</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`1` ～ `9`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }

        /// <summary>
        /// <para>用户角色</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `3`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_role")]
        public int? UserRole { get; set; }

        /// <summary>
        /// <para>用户名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }
    }

    /// <summary>
    /// <para>会议数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting")]
    public MeetingAgentEventMeeting? Meeting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record MeetingAgentEventMeeting
    {
        /// <summary>
        /// <para>会议ID</para>
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
        /// <para>9位会议号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议开始时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>会议结束时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>会议主持人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("host_user")]
        public MeetingAgentEventUser? HostUser { get; set; }
    }

    /// <summary>
    /// <para>被邀请的 Bot 用户</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot")]
    public MeetingAgentEventUser? Bot { get; set; }

    /// <summary>
    /// <para>邀请人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("inviter")]
    public MeetingAgentEventUser? Inviter { get; set; }

    /// <summary>
    /// <para>邀请时间（秒级 unix 时间戳，序列化为字符串避免 JS int64 精度丢失）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invite_time")]
    public string? InviteTime { get; set; }

    /// <summary>
    /// <para>邀请-入会链路的关联标识，由服务端生成。Agent 收到后必须在调用「加入会议」接口时原样回传。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }
}
