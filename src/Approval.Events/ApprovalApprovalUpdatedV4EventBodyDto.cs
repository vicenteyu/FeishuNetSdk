// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApprovalApprovalUpdatedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批定义更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 审批定义更新 事件体
/// <para>审批定义的基础信息、表单设计或流程设计等信息发生变更时，触发该事件。</para>
/// <para>接口ID：7013346140632416284</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/common-event/custom-approval-event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fcustom-approval-event</para>
/// </summary>
public record ApprovalApprovalUpdatedV4EventBodyDto() : EventBodyDto("approval.approval.updated_v4")
{
    /// <summary>
    /// <para>事件详细数据</para>
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
        /// <para>审批定义 Code</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approval_code")]
        public string? ApprovalCode { get; set; }

        /// <summary>
        /// <para>审批定义 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approval_id")]
        public string? ApprovalId { get; set; }

        /// <summary>
        /// <para>扩展字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>表单定义 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("form_definition_id")]
        public string? FormDefinitionId { get; set; }

        /// <summary>
        /// <para>审批流程表单 JSON 数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("process_obj")]
        public string? ProcessObj { get; set; }

        /// <summary>
        /// <para>审批定义更新时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// <para>审批定义的版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>控件组类型，返回 0 表示未使用</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("widget_group_type")]
        public int? WidgetGroupType { get; set; }
    }
}
