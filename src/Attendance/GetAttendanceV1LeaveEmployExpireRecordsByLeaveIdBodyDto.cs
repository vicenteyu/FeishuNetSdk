using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 通过过期时间获取发放记录 请求体
/// <para>只能获取到对应时间段过期的发放记录</para>
/// <para>接口ID：7239198678939697156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_employ_expire_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_employ_expire_record%2fget</para>
/// </summary>
public record GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdBodyDto
{
    /// <summary>
    /// <para>员工ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonProperty("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>假期类型ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7111688079785723436</para>
    /// </summary>
    [JsonProperty("leave_type_id")]
    public string LeaveTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>失效最早日期  2023-04-10 格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：2023-04-10</para>
    /// </summary>
    [JsonProperty("start_expiration_date")]
    public string StartExpirationDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>失效最晚日期 2023-05-10 格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：2023-05-10</para>
    /// </summary>
    [JsonProperty("end_expiration_date")]
    public string EndExpirationDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>时间偏移，东八区：480    8*60， 如果没有这个参数，默认东八区</para>
    /// <para>必填：否</para>
    /// <para>示例值：480</para>
    /// </summary>
    [JsonProperty("time_offset")]
    public int? TimeOffset { get; set; }
}
