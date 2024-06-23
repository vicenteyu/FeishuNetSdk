// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1ApprovalInfosProcessResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通知审批状态更新 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 通知审批状态更新 响应体
/// <para>对于只使用飞书考勤系统而未使用飞书审批系统的企业，可以通过该接口更新写入飞书考勤系统中的三方系统审批状态，例如请假、加班、外出、出差、补卡等审批，状态包括通过、不通过、撤销等。</para>
/// <para>接口ID：7108645368100290562</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/process</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fapproval_info%2fprocess</para>
/// </summary>
public record PostAttendanceV1ApprovalInfosProcessResponseDto
{
    /// <summary>
    /// <para>审批信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_info")]
    public PostAttendanceV1ApprovalInfosProcessResponseDtoApprovalInfo? ApprovalInfo { get; set; }

    /// <summary>
    /// <para>审批信息</para>
    /// </summary>
    public record PostAttendanceV1ApprovalInfosProcessResponseDtoApprovalInfo
    {
        /// <summary>
        /// <para>审批实例 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236113</para>
        /// </summary>
        [JsonPropertyName("approval_id")]
        public string ApprovalId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：remedy</para>
        /// <para>可选值：<list type="bullet">
        /// <item>leave：请假</item>
        /// <item>overtime：加班</item>
        /// <item>trip：出差</item>
        /// <item>out：外出</item>
        /// <item>remedy：补卡</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("approval_type")]
        public string ApprovalType { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：待审批</item>
        /// <item>1：未通过</item>
        /// <item>2：已通过</item>
        /// <item>3：已取消</item>
        /// <item>4：已撤回</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
