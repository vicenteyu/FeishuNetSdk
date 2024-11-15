// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1ContractFieldExtractionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提取文件中的合同字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 提取文件中的合同字段 请求体
/// <para>支持从doc、docx和pdf文件类型中提取合同字段。</para>
/// <para>文件大小需要小于10M。</para>
/// <para>接口ID：7220312184105664515</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/contract/field_extraction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fcontract%2ffield_extraction</para>
/// </summary>
public record PostDocumentAiV1ContractFieldExtractionBodyDto
{
    /// <summary>
    /// <para>pdf页数限制，太长会导致latency增加，最大允许100页</para>
    /// <para>必填：是</para>
    /// <para>示例值：15</para>
    /// </summary>
    [JsonPropertyName("pdf_page_limit")]
    public int PdfPageLimit { get; set; }

    /// <summary>
    /// <para>ocr 参数，当前支持force, pdf, unused三种格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：auto</para>
    /// <para>可选值：<list type="bullet">
    /// <item>force：pdf类型文件直接走OCR解析</item>
    /// <item>auto：pdf类型文件先走本地解析，无法解析（扫描/图片版）再走OCR</item>
    /// <item>unused：不调用OCR，扫描/图片PDF返回不可解析信息</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("ocr_mode")]
    public string OcrMode { get; set; } = string.Empty;
}
