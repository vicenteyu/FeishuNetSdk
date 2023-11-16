namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 转交审批任务 请求体
/// <para>对于单个审批任务进行转交操作。转交后审批流程流转给被转交人。</para>
/// <para>接口ID：7114621541589778435</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/transfer</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2ftransfer</para>
/// </summary>
public record PostApprovalV4TasksTransferBodyDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>**示例值**："7C468A54-8745-2245-9675-08B7C63E7A85"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>**示例值**："81D31358-93AF-92D6-7425-01A5D67C4E71"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>根据user_id_type填写操作用户id</para>
    /// <para>**示例值**："f7cb567e"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意见</para>
    /// <para>**示例值**："OK"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>根据user_id_type填写被转交人唯一 ID</para>
    /// <para>**示例值**："f4ip317q"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("transfer_user_id")]
    public string TransferUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务 ID， 审批实例详情task_list中id</para>
    /// <para>**示例值**："12345"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;
}
