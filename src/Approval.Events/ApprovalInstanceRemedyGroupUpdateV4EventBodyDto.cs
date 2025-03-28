// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="ApprovalInstanceRemedyGroupUpdateV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>补卡审批 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 补卡审批 事件体
/// <para>审批定义的表单包含 **补卡控件组** 时，该定义下的审批实例通过时，触发该事件。</para>
/// <para>接口ID：7013340088257445916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/attendance-record-correction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fattendance-record-correction</para>
/// </summary>
public record ApprovalInstanceRemedyGroupUpdateV4EventBodyDto() : EventBodyDto("approval.instance.remedy_group_update_v4")
{
    /// <summary>
    /// <para>事件详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object")]
    public ObjectSuffix? Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ObjectSuffix
    {
        /// <summary>
        /// <para>审批发起人的 user_id。你可以调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，通过 user_id 获取用户信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// <para>审批实例 Code。可调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)接口查询审批实例详情。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// <para>审批发起时间，秒级时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>审批结束时间，秒级时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>补卡时间，毫秒级时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("remedy_time")]
        public long? RemedyTime { get; set; }

        /// <summary>
        /// <para>补卡原因。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("remedy_reason")]
        public string? RemedyReason { get; set; }

        /// <summary>
        /// <para>审批实例状态。审批实例通过时取值为 `APPROVED`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>固定取值 `remedy_approval_v2`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
