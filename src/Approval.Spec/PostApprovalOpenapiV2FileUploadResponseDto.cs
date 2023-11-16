namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 上传文件 响应体
/// <para>当审批表单中有图片或附件控件时，开发者需在创建审批实例前通过审批上传文件接口将文件上传到审批系统，且附件上传大小限制为50M，图片上传大小为10M。</para>
/// <para>接口ID：6907569745298767874</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/file/upload-files</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDOyUjL1gjM14SN4ITN</para>
/// </summary>
public record PostApprovalOpenapiV2FileUploadResponseDto
{
    /// <summary>
    /// <para>文件标识码（用于创建审批实例）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件 url</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
