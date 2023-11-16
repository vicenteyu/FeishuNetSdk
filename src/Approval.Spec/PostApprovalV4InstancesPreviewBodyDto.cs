namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 预览审批流程 请求体
/// <para>提交审批前，预览审批流程。或者发起审批后，在某一审批节点预览后续流程。</para>
/// <para>接口ID：6995509710095695876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/approval-preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-preview</para>
/// </summary>
public record PostApprovalV4InstancesPreviewBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>发起审批用户，employeid或者openid</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户部门，如果用户只属于一个部门，可以不填，如果属于多个部门，必须填其中一个部门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>JSON字符串，控件值。提交审批之前，查看预览流程时，该字段必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string? Form { get; set; }

    /// <summary>
    /// <para>控件ID，也可以使用自定义 ID custom_id 的值</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// <para>控件类型</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>控件值，不同类型的值格式不一样</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>若审批实例已存在，则传递当前审批任务对应的task_id, 并且user_id需要传task的指派人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
