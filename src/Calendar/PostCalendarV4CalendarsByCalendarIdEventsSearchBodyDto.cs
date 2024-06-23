// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索日程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日程 请求体
/// <para>调用该接口以用户身份搜索指定日历下的相关日程。</para>
/// <para>接口ID：6952888507003109403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键字。用于模糊查询日程名称。</para>
    /// <para>必填：是</para>
    /// <para>示例值：query words</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>搜索过滤器。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public EventSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>搜索过滤器。</para>
    /// </summary>
    public record EventSearchFilter
    {
        /// <summary>
        /// <para>搜索过滤项，日程搜索区间的开始时间。不传值则表示不设置该过滤项。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeInfo? StartTime { get; set; }

        /// <summary>
        /// <para>搜索过滤项，日程搜索区间的开始时间。不传值则表示不设置该过滤项。</para>
        /// </summary>
        public record TimeInfo
        {
            /// <summary>
            /// <para>以天为最小单位指定开始时间，[RFC 3339](https://datatracker.ietf.org/doc/html/rfc3339) 格式，例如，2018-09-01。</para>
            /// <para>**注意**：该参数不能与 `timestamp` 同时指定。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2018-09-01</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>秒级时间戳，指具体的开始时间。例如，1602504000 表示 2020/10/12 20:00:00（UTC +8 时区）。</para>
            /// <para>**注意**：该参数不能与 `date` 同时指定。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1602504000</para>
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>时区。使用 IANA Time Zone Database 标准，例如 Asia/Shanghai。</para>
            /// <para>- 全天时区固定为UTC +0</para>
            /// <para>- 非全天时区默认为 Asia/Shanghai</para>
            /// <para>必填：否</para>
            /// <para>示例值：Asia/Shanghai</para>
            /// </summary>
            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }
        }

        /// <summary>
        /// <para>搜索过滤项，日程搜索区间的结束时间。不传值则表示不设置该过滤项。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public TimeInfo? EndTime { get; set; }

        /// <summary>
        /// <para>搜索过滤项，日程参与人的用户 ID 列表。设置该字段后，被搜索到的日程中至少包含其中一个参与人。</para>
        /// <para>**注意**：用户 ID 类型和 user_id_type 的值保持一致，关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**默认值**：空，表示不设置该过滤项</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        public string[]? UserIds { get; set; }

        /// <summary>
        /// <para>搜索过滤项，会议室 ID 列表。设置该字段后，被搜索到的日程中至少包含其中一个会议室。</para>
        /// <para>**默认值**：空，表示不设置该过滤项</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("room_ids")]
        public string[]? RoomIds { get; set; }

        /// <summary>
        /// <para>搜索过滤项，群 ID 列表。设置该字段后，被搜索到的日程中至少包含其中一个群。关于群 ID 可参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
        /// <para>**默认值**：空，表示不设置该过滤项</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("chat_ids")]
        public string[]? ChatIds { get; set; }
    }
}
