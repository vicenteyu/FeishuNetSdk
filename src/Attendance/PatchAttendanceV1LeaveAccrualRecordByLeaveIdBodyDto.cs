// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchAttendanceV1LeaveAccrualRecordByLeaveIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改发放记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 修改发放记录 请求体
/// <para>更新发放记录的发放数量和失效日期，对应假勤管理-休假管理-[发放记录](https://example.feishu.cn/people/workforce-management/manage/leave/leave_admin/granting_record)</para>
/// <para>接口ID：7239198678939713540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_accrual_record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_accrual_record%2fpatch</para>
/// </summary>
public record PatchAttendanceV1LeaveAccrualRecordByLeaveIdBodyDto
{
    /// <summary>
    /// <para>发放记录的唯一ID，可通过[创建假期发放记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave_granting_record/create)</para>
    /// <para>必填：是</para>
    /// <para>示例值：6893014062142064135</para>
    /// </summary>
    [JsonPropertyName("leave_granting_record_id")]
    public string LeaveGrantingRecordId { get; set; } = string.Empty;

    /// <summary>
    /// <para>员工ID，对应employee_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>假期类型ID，可通过[获取假期类型列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/leave_types)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7111688079785723436</para>
    /// </summary>
    [JsonPropertyName("leave_type_id")]
    public string LeaveTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>修改发放记录原因</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public LangText[] Reasons { get; set; } = Array.Empty<LangText>();

    /// <summary>
    /// <para>修改发放记录原因</para>
    /// </summary>
    public record LangText
    {
        /// <summary>
        /// <para>语言码</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>语言码对应的文本</para>
        /// <para>必填：是</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>时间偏移，东八区：480 8*60</para>
    /// <para>必填：否</para>
    /// <para>示例值：480</para>
    /// </summary>
    [JsonPropertyName("time_offset")]
    public int? TimeOffset { get; set; }

    /// <summary>
    /// <para>失效日期，格式"2020-01-01"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// <para>修改source 余额</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }
}
