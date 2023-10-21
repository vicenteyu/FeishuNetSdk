using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 批量查询打卡流水 请求体
/// <para>批量查询授权内员工的实际打卡流水记录。例如，企业给一个员工设定的班次是上午 9 点和下午 6 点各打一次上下班卡，但是该员工在这期间打了多次卡，该接口会把所有的打卡记录都返回。</para>
/// <para>接口ID：7044467124773617665</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fquery</para>
/// </summary>
public record PostAttendanceV1UserFlowsQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表，长度不超过 50</para>
    /// <para>必填：是</para>
    /// <para>示例值：["abd754f7"]</para>
    /// </summary>
    [JsonProperty("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询的起始时间，时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonProperty("check_time_from")]
    public string CheckTimeFrom { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询的结束时间，时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonProperty("check_time_to")]
    public string CheckTimeTo { get; set; } = string.Empty;
}
