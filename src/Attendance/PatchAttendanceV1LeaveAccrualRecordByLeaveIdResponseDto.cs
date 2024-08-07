// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchAttendanceV1LeaveAccrualRecordByLeaveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改发放记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 修改发放记录 响应体
/// <para>更新发放记录的发放数量和失效日期，对应假勤管理-休假管理-[发放记录](https://example.feishu.cn/people/workforce-management/manage/leave/leave_admin/granting_record)</para>
/// <para>接口ID：7239198678939713540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_accrual_record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_accrual_record%2fpatch</para>
/// </summary>
public record PatchAttendanceV1LeaveAccrualRecordByLeaveIdResponseDto
{
    /// <summary>
    /// <para>员工过期日期的发放记录</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("record")]
    public LeaveAccrualRecord Record { get; set; } = new();

    /// <summary>
    /// <para>员工过期日期的发放记录</para>
    /// </summary>
    public record LeaveAccrualRecord
    {
        /// <summary>
        /// <para>发放记录唯一ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工ID，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：6982509313466189342</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("leave_type_id")]
        public string LeaveTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放数量</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("granting_quantity")]
        public string GrantingQuantity { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放单位，1表示天，2表示小时</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("granting_unit")]
        public int GrantingUnit { get; set; }

        /// <summary>
        /// <para>生效日期，格式为yyyy-MM-dd</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效日期，格式为yyyy-MM-dd</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放来源，1：系统发放；2：手动发放；3：外部系统发放</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("granted_by")]
        public int GrantedBy { get; set; }

        /// <summary>
        /// <para>发放原因</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public LangText[] Reasons { get; set; } = Array.Empty<LangText>();

        /// <summary>
        /// <para>发放原因</para>
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
        /// <para>发放记录的创建时间，unix时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1687428000</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的创建人的ID，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：6982509313466189342</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的更新时间，unix时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1687428000</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的更新人的ID，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：6982509313466189342</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
