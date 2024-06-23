// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocxV1DocumentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档 响应体
/// <para>创建文档类型为 docx 的文档。你可选择传入文档标题和文件夹。</para>
/// <para>接口ID：7068199542315204636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsResponseDto
{
    /// <summary>
    /// <para>新建文档的文档信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("document")]
    public PostDocxV1DocumentsResponseDtoDocument? Document { get; set; }

    /// <summary>
    /// <para>新建文档的文档信息</para>
    /// </summary>
    public record PostDocxV1DocumentsResponseDtoDocument
    {
        /// <summary>
        /// <para>文档的唯一标识。点击[这里](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-overview)了解如何获取文档的 `document_id`</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxbcmEtbFrbbq10nPNu8gabcef</para>
        /// <para>最大长度：27</para>
        /// <para>最小长度：27</para>
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// <para>文档版本 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("revision_id")]
        public int? RevisionId { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：undefined</para>
        /// <para>最大长度：800</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}
