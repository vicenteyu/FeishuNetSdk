// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过过期时间获取发放记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 通过过期时间获取发放记录 响应体
/// <para>只能获取到对应时间段过期的发放记录</para>
/// <para>接口ID：7239198678939697156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_employ_expire_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_employ_expire_record%2fget</para>
/// </summary>
public record GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdResponseDto
{
    /// <summary>
    /// <para>员工过期日期的发放记录</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("records")]
    public LeaveEmployExpireRecord[] Records { get; set; } = [];

    /// <summary>
    /// <para>员工过期日期的发放记录</para>
    /// </summary>
    public record LeaveEmployExpireRecord
    {
        /// <summary>
        /// <para>发放记录ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工ID，与user_id_type保持一致</para>
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
        /// <para>剩余数量</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("left_granting_quantity")]
        public string LeftGrantingQuantity { get; set; } = string.Empty;

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
        /// <para>发放原因</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public LangText[] Reasons { get; set; } = [];

        /// <summary>
        /// <para>发放原因</para>
        /// </summary>
        public record LangText
        {
            /// <summary>
            /// <para>语言码</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_CN</para>
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
        /// <para>是否已经被外部系统更改过</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_update_by_external")]
        public bool IsUpdateByExternal { get; set; }

        /// <summary>
        /// <para>发放来源</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：系统发放</item>
        /// <item>2：人工发放</item>
        /// <item>3：外部系统发放</item>
        /// <item>4：虚拟发放</item>
        /// <item>5：旧系统导入</item>
        /// <item>6：加班转入</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("accrual_source")]
        public int AccrualSource { get; set; }

        /// <summary>
        /// <para>假期子类型id</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("leave_sub_type_id")]
        public string LeaveSubTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否参与折算（1不参与折算，2参与折算）。默认不折算</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("section_type")]
        public int? SectionType { get; set; }
    }
}
