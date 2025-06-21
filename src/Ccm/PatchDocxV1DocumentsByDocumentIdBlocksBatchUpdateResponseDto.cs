// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量更新块的内容 响应体
/// <para>批量更新块的富文本内容。</para>
/// <para>接口ID：7100866542866530308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fbatch_update</para>
/// </summary>
public record PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto
{
    /// <summary>
    /// <para>批量更新的 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("blocks")]
    public Dtos.Block[]? Blocks { get; set; }

    /// <summary>
    /// <para>当前更新成功后文档的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("document_revision_id")]
    public int? DocumentRevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：是</para>
    /// <para>示例值：8aac2291-bc9e-4b12-a162-b3cf15bb06bd</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string ClientToken { get; set; } = string.Empty;
}
