namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 预览审批流程 响应体
/// <para>提交审批前，预览审批流程。或者发起审批后，在某一审批节点预览后续流程。</para>
/// <para>接口ID：6995509710095695876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/approval-preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-preview</para>
/// </summary>
public record PostApprovalV4InstancesPreviewResponseDto
{
    /// <summary>
    /// <para>预览节点信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("preview_nodes")]
    public PreviewNode[] PreviewNodes { get; set; } = Array.Empty<PreviewNode>();

    /// <summary></summary>
    public record PreviewNode
    {
        /// <summary>
        /// <para>审批人id列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public string[] UserIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>审批结束抄送人id列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("end_cc_id_list")]
        public string[] EndCcIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>节点id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string NodeName { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点类型：</para>
        /// <para>AND：会签</para>
        /// <para>OR: 或签</para>
        /// <para>AUTO_PASS:自动通过</para>
        /// <para>AUTO_REJECT:自动拒绝</para>
        /// <para>SEQUENTIAL:按顺序</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string NodeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户自定义节点id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("custom_node_id")]
        public string CustomNodeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点的说明信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("comments")]
        public object[] Comments { get; set; } = Array.Empty<object>();

        /// <summary>
        /// <para>审批人是否为空，若为空，则user_id_list为兜底审批人id列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("is_empty_logic")]
        public bool IsEmptyLogic { get; set; }

        /// <summary>
        /// <para>是否发起人自选节点</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("is_approver_type_free")]
        public bool IsApproverTypeFree { get; set; }

        /// <summary>
        /// <para>节点是否支持抄送人自选</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("has_cc_type_free")]
        public bool HasCcTypeFree { get; set; }
    }
}
