// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="PostCorehrV1LeavesWorkCalendarDateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作日历日期详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取工作日历日期详情 响应体
/// <para>获取工作日历每一天的日期详情，如日期、日期类型等</para>
/// <para>接口ID：7408403062694084611</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar_date</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar_date</para>
/// </summary>
public record PostCorehrV1LeavesWorkCalendarDateResponseDto
{
    /// <summary>
    /// <para>日期列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("calendar_dates")]
    public WkCalendarDate[]? CalendarDates { get; set; }

    /// <summary>
    /// <para>日期列表</para>
    /// </summary>
    public record WkCalendarDate
    {
        /// <summary>
        /// <para>工作日历ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7390282135276635692</para>
        /// </summary>
        [JsonPropertyName("calendar_id")]
        public string? CalendarId { get; set; }

        /// <summary>
        /// <para>日期，格式："2006-01-02"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2006-01-02</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>日期类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：day_off</para>
        /// <para>可选值：<list type="bullet">
        /// <item>day_off：休息日</item>
        /// <item>public_holiday：公共假日</item>
        /// <item>workday：工作日</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("date_type")]
        public string? DateType { get; set; }

        /// <summary>
        /// <para>日期id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7390282135276635692</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
