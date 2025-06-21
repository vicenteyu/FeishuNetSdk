// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostDocxV1DocumentsByDocumentIdBlocksByBlockIdDescendantResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建嵌套块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建嵌套块 响应体
/// <para>接口ID：7324523155900366876</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/docs/document-block/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-descendant%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsByDocumentIdBlocksByBlockIdDescendantResponseDto
{
    /// <summary>
    /// <para>所添加的孩子的 Block 信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：111</para>
    /// </summary>
    [JsonPropertyName("children")]
    public Dtos.Block[]? Childrens { get; set; }

    /// <summary>
    /// <para>当前提交的 Block 创建成功后文档的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("document_revision_id")]
    public int? DocumentRevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：80bf5b2a-4dea-4c02-8a84-a0e682de463d</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }

    /// <summary>
    /// <para>传入的临时 BlockID 与真实 BlockID 映射关系</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block_id_relations")]
    public BlockIdRelation[]? BlockIdRelations { get; set; }

    /// <summary>
    /// <para>传入的临时 BlockID 与真实 BlockID 映射关系</para>
    /// </summary>
    public record BlockIdRelation
    {
        /// <summary>
        /// <para>用户传入的临时 BlockID</para>
        /// <para>必填：否</para>
        /// <para>示例值：80bf5b2a-4dea-4c02-8a84-a0e682de463d</para>
        /// </summary>
        [JsonPropertyName("temporary_block_id")]
        public string? TemporaryBlockId { get; set; }

        /// <summary>
        /// <para>真实使用的 BlockID</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxbcQOmtfkzY6BFFVQ86LH2J2d</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string? BlockId { get; set; }
    }
}
