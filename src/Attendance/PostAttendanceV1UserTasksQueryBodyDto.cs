using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询打卡结果 请求体
/// <para>获取企业内员工的实际打卡结果，包括上班打卡结果和下班打卡结果。</para>
/// <para>接口ID：7044467124773421057</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task%2fquery</para>
/// </summary>
public record PostAttendanceV1UserTasksQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表，长度不超过 50</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
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

    /// <summary>
    /// <para>是否需要加班班段打卡结果；加班班段通过task_shift_type=1标识，加班班段上下班与正常班段相连时 会出现共用flow_id情况。例如：9-18为正常班次，18-19为加班班次，打卡结果中records 会出现两段，分别为9-18，18-19 且两段上下班flow_id相同。非相连加班班次正常分段返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("need_overtime_result")]
    public bool? NeedOvertimeResult { get; set; }
}
