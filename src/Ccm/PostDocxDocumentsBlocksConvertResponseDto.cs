// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-21
//
// Last Modified By : yxr
// Last Modified On : 2025-06-21
// ************************************************************************
// <copyright file="PostDocxDocumentsBlocksConvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换为文档块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// Markdown/HTML 内容转换为文档块 响应体
/// <para>将 HTML/Markdown 格式的内容转换为文档块</para>
/// <para>接口ID：7514526156452954140</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fconvert</para>
/// </summary>
public record PostDocxDocumentsBlocksConvertResponseDto
{
    /// <summary>
    /// <para>第一级 Block 对应的临时 ID 列表， index 代表了 Block 的顺序</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("first_level_block_ids")]
    public string[]? FirstLevelBlockIds { get; set; }

    /// <summary>
    /// <para>带有父子关系的 Block 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("blocks")]
    public Dtos.Block[]? Blocks { get; set; }

    /// <summary>
    /// <para>如果要转换的内容中带有图片，这里记录了临时 Block ID 和 Image URL 的对应关系</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block_id_to_image_urls")]
    public BlockIdToImageUrl[]? BlockIdToImageUrls { get; set; }

    /// <summary>
    /// <para>如果要转换的内容中带有图片，这里记录了临时 Block ID 和 Image URL 的对应关系</para>
    /// </summary>
    public record BlockIdToImageUrl
    {
        /// <summary>
        /// <para>块 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：93b37f5b-8b45-4c03-9379-af988c178b19</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; } = string.Empty;

        /// <summary>
        /// <para>图片 URL</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://sf3-scmcdn-cn.feishucdn.com/obj/feishu-static/lark/open/website/share-logo.png</para>
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
