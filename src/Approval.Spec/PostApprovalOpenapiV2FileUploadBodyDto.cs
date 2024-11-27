// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV2FileUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 上传文件 请求体
/// <para>当审批表单中有图片或附件控件时，开发者需在创建审批实例前通过审批上传文件接口将文件上传到审批系统，并获取本接口返回的 code，后续在[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)时，将 code 传入图片控件或者附件控件的 value 字段内。</para>
/// <para>例如，以下是创建审批实例时，图片控件值示例，其中的 value 为本接口返回的图片 code。</para>
/// <para>{</para>
/// <para>"id":"widget1",</para>
/// <para>"type":"image",</para>
/// <para>"value": ["D93653C3-2609-4EE0-8041-61DC1D84F0B5"]</para>
/// <para>}</para>
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
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件类型（image 或 attachment）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
