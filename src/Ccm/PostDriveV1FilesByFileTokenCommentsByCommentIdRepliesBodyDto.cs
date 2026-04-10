// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加回复 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加回复 请求体
/// <para>使用该接口可对云文档中的某条评论进行回复，回复内容支持普通文本、云文档链接等。</para>
/// <para>接口ID：7625922449226419390</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesBodyDto
{
    /// <summary>
    /// <para>回复内容</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("content")]
    public ReplyContent Content { get; set; } = new();

    /// <summary>
    /// <para>回复内容</para>
    /// </summary>
    public record ReplyContent
    {
        /// <summary>
        /// <para>回复内容的元素列表。最大元素个数为100</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("elements")]
        public ReplyElement[] Elements { get; set; } = [];

        /// <summary>
        /// <para>回复内容的元素列表。最大元素个数为100</para>
        /// </summary>
        public record ReplyElement
        {
            /// <summary>
            /// <para>回复内容的元素类型。同时传入多个子参数时，仅与 type 取值匹配的参数生效，其他忽略</para>
            /// <para>必填：是</para>
            /// <para>示例值：docs_link</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text_run：普通文本</item>
            /// <item>docs_link：at 云文档链接</item>
            /// <item>person：at 联系人</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_run")]
            public TextRunSuffix? TextRun { get; set; }

            /// <summary>
            /// <para>文本内容</para>
            /// </summary>
            public record TextRunSuffix
            {
                /// <summary>
                /// <para>回复 普通文本</para>
                /// <para>type为“text_run”时，此项必填。最大长度 10000字符</para>
                /// <para>必填：是</para>
                /// <para>示例值：reply text</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string Text { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>云文档链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("docs_link")]
            public DocsLinkSuffix? DocsLink { get; set; }

            /// <summary>
            /// <para>云文档链接</para>
            /// </summary>
            public record DocsLinkSuffix
            {
                /// <summary>
                /// <para>回复 at 云文档</para>
                /// <para>type为“docs_link”时，此项必填</para>
                /// <para>必填：是</para>
                /// <para>示例值：https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>联系人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("person")]
            public PersonSuffix? Person { get; set; }

            /// <summary>
            /// <para>联系人</para>
            /// </summary>
            public record PersonSuffix
            {
                /// <summary>
                /// <para>回复 at 联系人</para>
                /// <para>type为“person”时，此项必填。类型需与查询参数 user_id_type 的取值一致</para>
                /// <para>必填：是</para>
                /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string UserId { get; set; } = string.Empty;
            }
        }
    }
}
