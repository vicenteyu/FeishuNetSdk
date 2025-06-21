// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新块的内容 响应体
/// <para>更新指定的块。</para>
/// <para>接口ID：7068199542315286556</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fpatch</para>
/// </summary>
public record PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto
{
    /// <summary>
    /// <para>更新后的 block 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block")]
    public Dtos.Block? Block { get; set; }

    /// <summary>
    /// <para>当前更新成功后文档的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("document_revision_id")]
    public int? DocumentRevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string ClientToken { get; set; } = string.Empty;
}
