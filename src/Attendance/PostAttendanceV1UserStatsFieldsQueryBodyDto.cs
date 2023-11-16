namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计表头 请求体
/// <para>查询考勤统计支持的日度统计或月度统计的统计表头。</para>
/// <para>接口ID：7044467124773814273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_field%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsFieldsQueryBodyDto
{
    /// <summary>
    /// <para>语言类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：zh</para>
    /// <para>可选值：<list type="bullet">
    /// <item>en：英语</item>
    /// <item>ja：日语</item>
    /// <item>zh：中文</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string Locale { get; set; } = string.Empty;

    /// <summary>
    /// <para>统计类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：daily</para>
    /// <para>可选值：<list type="bullet">
    /// <item>daily：日度统计</item>
    /// <item>month：月度统计</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("stats_type")]
    public string StatsType { get; set; } = string.Empty;

    /// <summary>
    /// <para>开始时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210316</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public int StartDate { get; set; }

    /// <summary>
    /// <para>结束时间（时间间隔不超过 40 天）</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210323</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public int EndDate { get; set; }
}
