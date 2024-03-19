namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 拒绝人工任务 请求体
/// <para>对于人工任务进行拒绝操作</para>
/// <para>接口ID：7347562540447088641</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/approval_task/reject</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2freject</para>
/// </summary>
public record PostApaasV1ApprovalTasksByApprovalTaskIdRejectBodyDto
{
    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1783981209205788</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见</para>
    /// <para>必填：否</para>
    /// <para>示例值：拒绝</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string? Opinion { get; set; }
}
