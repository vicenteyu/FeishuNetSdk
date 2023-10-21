using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 上传文件 请求体
/// <para>当审批表单中有图片或附件控件时，开发者需在创建审批实例前通过审批上传文件接口将文件上传到审批系统，且附件上传大小限制为50M，图片上传大小为10M。</para>
/// <para>接口ID：6907569745298767874</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/file/upload-files</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDOyUjL1gjM14SN4ITN</para>
/// </summary>
public record PostApprovalOpenapiV2FileUploadBodyDto
{
    /// <summary>
    /// <para>文件名（需包含文件扩展名，如“文件.doc”</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件类型（image 或 attachment）</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
