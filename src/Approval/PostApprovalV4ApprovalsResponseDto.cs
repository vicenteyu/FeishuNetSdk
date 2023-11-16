namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建审批定义 响应体
/// <para>用于通过接口创建简单的审批定义，可以灵活指定定义的基础信息、表单和流程等。创建成功后，不支持从审批管理后台删除该定义。不推荐企业自建应用使用，如有需要尽量联系管理员在审批管理后台创建定义。</para>
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
public record PostApprovalV4ApprovalsResponseDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：否</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批定义 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7090754740375519252</para>
    /// </summary>
    [JsonPropertyName("approval_id")]
    public string? ApprovalId { get; set; }
}
