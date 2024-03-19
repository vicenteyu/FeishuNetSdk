namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 转交人工任务 请求体
/// <para>对于人工任务进行转交操作</para>
/// <para>接口ID：7347562540447105025</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/approval_task/transfer</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2ftransfer</para>
/// </summary>
public record PostApaasV1ApprovalTasksByApprovalTaskIdTransferBodyDto
{
    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1783981209205788</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>原审批人id</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("from_user_ids")]
    public string[]? FromUserIds { get; set; }

    /// <summary>
    /// <para>新审批人id</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("to_user_ids")]
    public string[]? ToUserIds { get; set; }

    /// <summary>
    /// <para>转交原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：转交</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string? Opinion { get; set; }
}
