// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="VcBotMeetingEndedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会议结束 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 会议结束 事件体
/// <para>当会议结束时，系统会向订阅方推送此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=bot&amp;event=meeting_ended)</para>
/// <para>接口ID：7672664994766966007</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_ended</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_ended</para>
/// </summary>
public record VcBotMeetingEndedV1EventBodyDto() : EventBodyDto("vc.bot.meeting_ended_v1")
{
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
    }
}
