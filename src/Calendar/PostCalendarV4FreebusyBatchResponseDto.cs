// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-03
//
// Last Modified By : yxr
// Last Modified On : 2025-12-12
// ************************************************************************
// <copyright file="PostCalendarV4FreebusyBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询主日历日程忙闲信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 批量查询主日历日程忙闲信息 响应体
/// <para>根据user id列表，批量查询指定用户的主日历在指定时间段内的忙碌时间段信息，适用于团队协作中，快速了解成员忙闲状态以安排会议或任务的场景。</para>
/// <para>接口ID：7327132452408426500</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2fbatch</para>
/// </summary>
public record PostCalendarV4FreebusyBatchResponseDto
{
    /// <summary>
    /// <para>用户忙闲信息列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("freebusy_lists")]
    public UserFreebusy[]? FreebusyLists { get; set; }

    /// <summary>
    /// <para>用户忙闲信息列表。</para>
    /// </summary>
    public record UserFreebusy
    {
        /// <summary>
        /// <para>在请求的时间区间内的忙闲时间段信息。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("freebusy_items")]
        public Freebusy[]? FreebusyItems { get; set; }

        /// <summary>
        /// <para>在请求的时间区间内的忙闲时间段信息。</para>
        /// </summary>
        public record Freebusy
        {
            /// <summary>
            /// <para>忙闲信息开始时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2020-10-28T22:30:00+08:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>忙闲信息结束时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) date_time 格式。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2020-10-28T22:45:00+08:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>用户的RSVP状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：needs_action</para>
            /// <para>可选值：<list type="bullet">
            /// <item>needs_action：参与人尚未回复状态，或表示会议室预约中</item>
            /// <item>accept：参与人回复接受，或表示会议室预约成功</item>
            /// <item>tentative：参与人回复待定</item>
            /// <item>decline：参与人回复拒绝，或表示会议室预约失败</item>
            /// <item>removed：参与人或会议室已经从日程中被移除</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("rsvp_status")]
            public string? RsvpStatus { get; set; }
        }

        /// <summary>
        /// <para>日历创建者的用户 ID，根据查询参数 user_id_type 设置的 ID 类型进行返回。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_c186b6833e2d5faf2bc587e71ddabcef</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
