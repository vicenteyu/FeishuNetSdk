// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="PostCorehrV1LeavesWorkCalendarResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作日历 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取工作日历 响应体
/// <para>获取工作日历信息，如名称，状态等</para>
/// <para>接口ID：7408403062694100995</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar</para>
/// </summary>
public record PostCorehrV1LeavesWorkCalendarResponseDto
{
    /// <summary>
    /// <para>工作日历列表，对应入参的wk_calendar_ids</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("work_calendars")]
    public WorkCalendarDetail[]? WorkCalendars { get; set; }

    /// <summary>
    /// <para>工作日历列表，对应入参的wk_calendar_ids</para>
    /// </summary>
    public record WorkCalendarDetail
    {
        /// <summary>
        /// <para>工作日历ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7136914415957591596</para>
        /// </summary>
        [JsonPropertyName("calendar_id")]
        public string CalendarId { get; set; } = string.Empty;

        /// <summary>
        /// <para>工作日历名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("calendar_name")]
        public WkCalendarI18n? CalendarName { get; set; }

        /// <summary>
        /// <para>工作日历名称</para>
        /// </summary>
        public record WkCalendarI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：日历1</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：calendar1</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>工作日历是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }

    /// <summary>
    /// <para>入参count=true，则返回符合条件的工作日历总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
