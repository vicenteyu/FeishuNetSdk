using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询排班表 请求体
/// <para>支持查询多个用户的排班情况，查询的时间跨度不能超过 30 天。</para>
/// <para>接口ID：7044467124773552129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fquery</para>
/// </summary>
public record PostAttendanceV1UserDailyShiftsQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["abd754f7"]</para>
    /// </summary>
    [JsonProperty("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询的起始工作日</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190817</para>
    /// </summary>
    [JsonProperty("check_date_from")]
    public int CheckDateFrom { get; set; }

    /// <summary>
    /// <para>查询的结束工作日</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190820</para>
    /// </summary>
    [JsonProperty("check_date_to")]
    public int CheckDateTo { get; set; }
}
