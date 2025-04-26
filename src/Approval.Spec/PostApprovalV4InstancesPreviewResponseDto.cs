// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesPreviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>预览审批流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 预览审批流程 响应体
/// <para>在[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)之前，可调用本接口预览审批流程数据。在[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)之后，可调用本接口预览某一审批节点的后续流程数据。</para>
/// <para>接口ID：6995509710095695876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/approval-preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-preview</para>
/// </summary>
public record PostApprovalV4InstancesPreviewResponseDto
{
    /// <summary>
    /// <para>预览节点信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("preview_nodes")]
    public PreviewNode[]? PreviewNodes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record PreviewNode
    {
        /// <summary>
        /// <para>审批人 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public string[]? UserIdList { get; set; }

        /// <summary>
        /// <para>审批结束抄送人 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_cc_id_list")]
        public string[]? EndCcIdList { get; set; }

        /// <summary>
        /// <para>审批节点 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>审批节点名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string? NodeName { get; set; }

        /// <summary>
        /// <para>审批节点类型。可能值有：</para>
        /// <para>- AND：会签</para>
        /// <para>- OR：或签</para>
        /// <para>- AUTO_PASS：自动通过</para>
        /// <para>- AUTO_REJECT：自动拒绝</para>
        /// <para>- SEQUENTIAL：按顺序</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string? NodeType { get; set; }

        /// <summary>
        /// <para>用户自定义节点 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_node_id")]
        public string? CustomNodeId { get; set; }

        /// <summary>
        /// <para>节点的说明信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("comments")]
        public string[]? Comments { get; set; }

        /// <summary>
        /// <para>审批人是否为空，若为空，则 user_id_list 为兜底审批人 ID 列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_empty_logic")]
        public bool? IsEmptyLogic { get; set; }

        /// <summary>
        /// <para>是否发起人自选节点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_approver_type_free")]
        public bool? IsApproverTypeFree { get; set; }

        /// <summary>
        /// <para>节点是否支持抄送人自选</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("has_cc_type_free")]
        public bool? HasCcTypeFree { get; set; }
    }
}
