// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取块的内容 响应体
/// <para>获取指定块的富文本内容。</para>
/// <para>接口ID：7068199542315368476</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fget</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto
{
    /// <summary>
    /// <para>查询的 Block 的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block")]
    public Dtos.Block? Block { get; set; }
}
