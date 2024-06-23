// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1ApprovalInfosProcessBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通知审批状态更新 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 通知审批状态更新 请求体
/// <para>对于只使用飞书考勤系统而未使用飞书审批系统的企业，可以通过该接口更新写入飞书考勤系统中的三方系统审批状态，例如请假、加班、外出、出差、补卡等审批，状态包括通过、不通过、撤销等。</para>
/// <para>接口ID：7108645368100290562</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/process</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fapproval_info%2fprocess</para>
/// </summary>
public record PostAttendanceV1ApprovalInfosProcessBodyDto
{
    /// <summary>
    /// <para>审批实例 ID，获取方式：1）[获取审批通过数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_approval/query) 2）[写入审批结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_approval/create) 3）[通知补卡审批发起（补卡情况下）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_task_remedy/create)</para>
    /// <para>必填：是</para>
    /// <para>示例值：6737202939523236113</para>
    /// </summary>
    [JsonPropertyName("approval_id")]
    public string ApprovalId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批类型，leave：请假，out：外出，overtime：加班，trip：出差，remedy：补卡</para>
    /// <para>必填：是</para>
    /// <para>示例值：remedy</para>
    /// </summary>
    [JsonPropertyName("approval_type")]
    public string ApprovalType { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批状态</para>
    /// <para>- `1`：不通过</para>
    /// <para>- `2`：通过</para>
    /// <para>- `4`：撤销</para>
    /// <para>**注意**</para>
    /// <para>- **请假、外出、加班、出差**只支持传**撤销**</para>
    /// <para>- **补卡**支持传**不通过、通过和撤销**</para>
    /// <para>必填：是</para>
    /// <para>示例值：4</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}
