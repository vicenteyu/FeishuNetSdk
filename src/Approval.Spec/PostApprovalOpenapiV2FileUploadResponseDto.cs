// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV2FileUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 上传文件 响应体
/// <para>当审批表单中有图片或者附件控件时，开发者需要在调用[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)前，将传入图片或附件控件的文件通过本接口上传到审批系统，接口会返回文件的 code，该 code 用于创建审批实例时为图片或附件控件赋值。</para>
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
public record PostApprovalOpenapiV2FileUploadResponseDto
{
    /// <summary>
    /// <para>文件标识码。用于[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)时，传入图片控件或附件控件的 value 参数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>文件 url</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
