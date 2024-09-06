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
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 审批定义更新 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/common-event/custom-approval-event</para>
    /// </summary>
    public record ApprovalApprovalUpdatedV4EventBodyDto() : EventBodyDto("approval.approval.updated_v4")
    {
        /// <summary>
        /// 为当前的数据,事件的标准格式
        /// </summary>
        [JsonPropertyName("object")]
        public ObjectSuffix? Object { get; set; }

        /// <summary>
        /// 为当前的数据,事件的标准格式
        /// </summary>
        public record ObjectSuffix
        {
            /// <summary>
            /// 审批定义id
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

            /// <summary>
            /// 审批定义code
            /// </summary>
            [JsonPropertyName("approval_code")]
            public string? ApprovalCode { get; set; }

            /// <summary>
            /// 审批定义版本号
            /// </summary>
            [JsonPropertyName("version_id")]
            public string? VersionId { get; set; }

            /// <summary>
            /// 控件组类型，0表示未使用
            /// </summary>
            [JsonPropertyName("widget_group_type")]
            public string? WidgetGroupType { get; set; }

            /// <summary>
            /// 表单定义ID
            /// </summary>
            [JsonPropertyName("form_definition_id")]
            public string? FormDefinitionId { get; set; }

            /// <summary>
            /// 审批流程设计
            /// </summary>
            [JsonPropertyName("process_obj")]
            public string? ProcessObj { get; set; }

            /// <summary>
            /// 时间
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// 扩展字段
            /// </summary>
            [JsonPropertyName("extra")]
            public string? Extra { get; set; }
        }
    }
}
