// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocxV1DocumentsByDocumentIdBlocksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文档所有块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档所有块 响应体
/// <para>获取文档所有块的富文本内容并分页返回。</para>
/// <para>接口ID：7068199542315352092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2flist</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdBlocksResponseDto : IPageableResponse<Dtos.Block>
{
    /// <summary>
    /// <para>文档的 Block 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Dtos.Block[]? Items { get; set; }

    /// <summary>
    /// <para>下一个分页的分页标记</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有下一个分页</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
