namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取会议报告 响应体
/// <para>获取一段时间内组织的每日会议使用报告。</para>
/// <para>接口ID：6921909217674821659</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/report/get_daily</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freport%2fget_daily</para>
/// </summary>
public record GetVcV1ReportsGetDailyResponseDto
{
    /// <summary>
    /// <para>会议报告</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_report")]
    public Report? MeetingReport { get; set; }

    /// <summary>
    /// <para>会议报告</para>
    /// </summary>
    public record Report
    {
        /// <summary>
        /// <para>总会议数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("total_meeting_count")]
        public string? TotalMeetingCount { get; set; }

        /// <summary>
        /// <para>总会议时长（单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：300000</para>
        /// </summary>
        [JsonPropertyName("total_meeting_duration")]
        public string? TotalMeetingDuration { get; set; }

        /// <summary>
        /// <para>总参会人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：20000</para>
        /// </summary>
        [JsonPropertyName("total_participant_count")]
        public string? TotalParticipantCount { get; set; }

        /// <summary>
        /// <para>每日会议报告列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("daily_report")]
        public ReportMeetingDaily[]? DailyReports { get; set; }

        /// <summary>
        /// <para>每日会议报告列表</para>
        /// </summary>
        public record ReportMeetingDaily
        {
            /// <summary>
            /// <para>日期（unix时间，单位sec）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609113600</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>会议数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("meeting_count")]
            public string? MeetingCount { get; set; }

            /// <summary>
            /// <para>会议时长（单位sec）</para>
            /// <para>必填：否</para>
            /// <para>示例值：147680</para>
            /// </summary>
            [JsonPropertyName("meeting_duration")]
            public string? MeetingDuration { get; set; }

            /// <summary>
            /// <para>参会人数</para>
            /// <para>必填：否</para>
            /// <para>示例值：2000</para>
            /// </summary>
            [JsonPropertyName("participant_count")]
            public string? ParticipantCount { get; set; }
        }
    }
}
