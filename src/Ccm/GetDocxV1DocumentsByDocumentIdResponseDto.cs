// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDocxV1DocumentsByDocumentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文档基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档基本信息 响应体
/// <para>获取文档标题和最新版本 ID。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有云文档的阅读、编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7068199542315302940</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fget</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdResponseDto
{
    /// <summary>
    /// <para>文档信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("document")]
    public GetDocxV1DocumentsByDocumentIdResponseDtoDocument? Document { get; set; }

    /// <summary>
    /// <para>文档信息</para>
    /// </summary>
    public record GetDocxV1DocumentsByDocumentIdResponseDtoDocument
    {
        /// <summary>
        /// <para>文档的唯一标识。点击[这里](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-overview)了解如何获取文档的 `document_id`</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcni6mOy7jLRWbEylaKKC7K88</para>
        /// <para>最大长度：27</para>
        /// <para>最小长度：27</para>
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// <para>文档版本 ID。起始值为 1</para>
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
            /// <para>文档信息中是否展示关联事项。暂未支持</para>
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
            /// <para>视图在水平方向的偏移比例。其值为距离原图中心的水平方向偏移值 px / 原图宽度 px。</para>
            /// <para>视图在原图中心时，该值为 0；</para>
            /// <para>视图在原图右部分时，该值为正数；</para>
            /// <para>视图在原图左部分时，该值为负数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("offset_ratio_x")]
            public float? OffsetRatioX { get; set; }

            /// <summary>
            /// <para>视图在垂直方向的偏移比例。其值为距离原图中心的垂直方向偏移值 px / 原图高度 px。</para>
            /// <para>视图在原图中心时，该值为 0；</para>
            /// <para>视图在原图上部分时，该值为正数；</para>
            /// <para>视图在原图下部分时，该值为负数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("offset_ratio_y")]
            public float? OffsetRatioY { get; set; }
        }
    }
}
