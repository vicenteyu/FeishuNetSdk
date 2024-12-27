// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
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
        /// <para>文档的唯一标识。你可以将 `https://sample.feishu.cn/docx/` 与该标识拼接，并将 sample 替换为实际域名，生成文档的 URL 链接。如 `https://sample.feishu.cn/docx/doxbcmEtbFrbbq10nPNu8gabcef`。</para>
        /// <para>![](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/f8dac29d8ea3f01f5a651e0445193213_W0CZqRcbHM.png?height=639&amp;lazyload=true&amp;width=2161)</para>
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

        /// <summary>
        /// <para>文档展示设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display_setting")]
        public DocumentDisplaySetting? DisplaySetting { get; set; }

        /// <summary>
        /// <para>文档展示设置</para>
        /// </summary>
        public record DocumentDisplaySetting
        {
            /// <summary>
            /// <para>文档信息中是否展示文档作者</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_authors")]
            public bool? ShowAuthors { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示文档创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_create_time")]
            public bool? ShowCreateTime { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示文档访问次数</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_pv")]
            public bool? ShowPv { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示文档访问人数</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_uv")]
            public bool? ShowUv { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示点赞总数</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_like_count")]
            public bool? ShowLikeCount { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示评论总数</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_comment_count")]
            public bool? ShowCommentCount { get; set; }

            /// <summary>
            /// <para>文档信息中是否展示关联事项</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_related_matters")]
            public bool? ShowRelatedMatters { get; set; }
        }

        /// <summary>
        /// <para>文档封面</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cover")]
        public DocumentCover? Cover { get; set; }

        /// <summary>
        /// <para>文档封面</para>
        /// </summary>
        public record DocumentCover
        {
            /// <summary>
            /// <para>图片 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：O9E7bhebQooOzMx7yc7cSabcdef</para>
            /// <para>最大长度：27</para>
            /// <para>最小长度：27</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;

            /// <summary>
            /// <para>展示视图在水平方向的偏移比例。其值为距离原图中心的水平方向偏移值 px / 原图宽度 px。 视图在原图中心时，该值为 0； 视图在原图右部分时，该值为正数； 视图在原图左部分时，改值为负数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("offset_ratio_x")]
            public float? OffsetRatioX { get; set; }

            /// <summary>
            /// <para>展示视图在垂直方向的偏移比例。其值为距离原图中心的垂直方向偏移值 px / 原图高度 px。 视图在原图中心时，该值为 0； 视图在原图上部分时，该值为正数； 视图在原图下部分时，改值为负数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("offset_ratio_y")]
            public float? OffsetRatioY { get; set; }
        }
    }
}
