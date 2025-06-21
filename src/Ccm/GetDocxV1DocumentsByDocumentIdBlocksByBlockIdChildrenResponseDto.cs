// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取所有子块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取所有子块 响应体
/// <para>给定一个指定版本的文档，并指定需要操作的块，分页遍历其所有子块富文本内容 。如果不指定版本，则会默认查询最新版本。</para>
/// <para>接口ID：7068199542315253788</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fget</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto : IPageableResponse<Dtos.Block>
{
    /// <summary>
    /// <para>block 的 children 列表</para>
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
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
