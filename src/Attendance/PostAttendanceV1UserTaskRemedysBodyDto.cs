// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserTaskRemedysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通知补卡审批发起 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 通知补卡审批发起 请求体
/// <para>对于只使用飞书考勤系统而未使用飞书审批系统的企业，可以通过该接口，将在三方审批系统中发起的补卡审批数据，写入到飞书考勤系统中，状态为审批中。写入后可以由[通知审批状态更新](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/approval_info/process) 进行状态更新</para>
/// <para>接口ID：7044467124773715969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fcreate</para>
/// </summary>
public record PostAttendanceV1UserTaskRemedysBodyDto
{
    /// <summary>
    /// <para>用户 ID，对应employee_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补卡日期，日期格式yyyyMMdd</para>
    /// <para>必填：是</para>
    /// <para>示例值：20210701</para>
    /// </summary>
    [JsonPropertyName("remedy_date")]
    public int RemedyDate { get; set; }

    /// <summary>
    /// <para>第几次上下班，0：第 1 次上下班，1：第 2 次上下班，2：第 3 次上下班，自由班制填 0</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("punch_no")]
    public int PunchNo { get; set; }

    /// <summary>
    /// <para>上班 / 下班，1：上班，2：下班，自由班制填 0</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("work_type")]
    public int WorkType { get; set; }

    /// <summary>
    /// <para>补卡时间，时间格式为 yyyy-MM-dd HH:mm</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-07-01 08:00</para>
    /// </summary>
    [JsonPropertyName("remedy_time")]
    public string RemedyTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>补卡原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：忘记打卡</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// <para>字段已失效</para>
    /// <para>必填：否</para>
    /// <para>示例值：-</para>
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
