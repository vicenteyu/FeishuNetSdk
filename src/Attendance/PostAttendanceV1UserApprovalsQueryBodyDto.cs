using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取审批通过数据 请求体
/// <para>获取员工在某段时间内的请假、加班、外出和出差四种审批的通过数据。</para>
/// <para>接口ID：7108645368100257794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_approval%2fquery</para>
/// </summary>
public record PostAttendanceV1UserApprovalsQueryBodyDto
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
    /// <para>查询的结束工作日，与 check_date_from 的时间间隔不超过 30 天</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190820</para>
    /// </summary>
    [JsonProperty("check_date_to")]
    public int CheckDateTo { get; set; }

    /// <summary>
    /// <para>查询依据的时间类型（不填默认依据PeriodTime）</para>
    /// <para>必填：否</para>
    /// <para>示例值：PeriodTime</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PeriodTime：单据作用时间</item>
    /// <item>CreateTime：单据创建时间（目前暂不支持）</item>
    /// <item>UpdateTime：单据状态更新时间（新增字段，对特定租户生效）</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("check_date_type")]
    public string? CheckDateType { get; set; }

    /// <summary>
    /// <para>查询状态（不填默认查询已通过状态）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：待审批</item>
    /// <item>1：未通过</item>
    /// <item>2：已通过</item>
    /// <item>3：已取消</item>
    /// <item>4：已撤回</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>查询的起始时间，精确到秒的时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonProperty("check_time_from")]
    public string? CheckTimeFrom { get; set; }

    /// <summary>
    /// <para>查询的结束时间，精确到秒的时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1592561088</para>
    /// </summary>
    [JsonProperty("check_time_to")]
    public string? CheckTimeTo { get; set; }
}
