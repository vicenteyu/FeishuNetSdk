// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-02
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加全文评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加全文评论 响应体
/// <para>在文档中添加一条全局评论，不支持局部评论。</para>
/// <para>接口ID：6955017385137750017</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsResponseDto
{
    /// <summary>
    /// <para>评论 ID（创建新评论可不填；如填写，则视为回复已有评论）</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916106822734512356</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1610281603</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public long? CreateTime { get; set; }

    /// <summary>
    /// <para>更新时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1610281603</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public long? UpdateTime { get; set; }

    /// <summary>
    /// <para>是否已解决</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_solved")]
    public bool? IsSolved { get; set; }

    /// <summary>
    /// <para>解决评论时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1610281603</para>
    /// </summary>
    [JsonPropertyName("solved_time")]
    public int? SolvedTime { get; set; }

    /// <summary>
    /// <para>解决评论者的用户 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：null</para>
    /// </summary>
    [JsonPropertyName("solver_user_id")]
    public string? SolverUserId { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916106822734512356</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否是全文评论（本接口不返回该参数）</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_whole")]
    public bool? IsWhole { get; set; }

    /// <summary>
    /// <para>局部评论的引用字段（本接口不返回该参数）</para>
    /// <para>必填：否</para>
    /// <para>示例值：划词评论引用内容</para>
    /// </summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>
    /// <para>评论里的回复列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reply_list")]
    public PostDriveV1FilesByFileTokenCommentsResponseDtoReplyList? ReplyList { get; set; }

    /// <summary>
    /// <para>评论里的回复列表</para>
    /// </summary>
    public record PostDriveV1FilesByFileTokenCommentsResponseDtoReplyList
    {
        /// <summary>
        /// <para>回复列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("replies")]
        public FileCommentReply[] Replies { get; set; } = Array.Empty<FileCommentReply>();

        /// <summary>
        /// <para>回复列表</para>
        /// </summary>
        public record FileCommentReply
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
                /// <para>回复的内容</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("elements")]
                public ReplyElement[] Elements { get; set; } = Array.Empty<ReplyElement>();

                /// <summary>
                /// <para>回复的内容</para>
                /// </summary>
                public record ReplyElement
                {
                    /// <summary>
                    /// <para>回复的内容元素</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：text_run</para>
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
                    public ReplyElementTextRun? TextRun { get; set; }

                    /// <summary>
                    /// <para>文本内容</para>
                    /// </summary>
                    public record ReplyElementTextRun
                    {
                        /// <summary>
                        /// <para>回复 普通文本</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：comment text</para>
                        /// </summary>
                        [JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("docs_link")]
                    public ReplyElementDocsLink? DocsLink { get; set; }

                    /// <summary>
                    /// <para>文本内容</para>
                    /// </summary>
                    public record ReplyElementDocsLink
                    {
                        /// <summary>
                        /// <para>回复 at 云文档</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("person")]
                    public ReplyElementPerson? Person { get; set; }

                    /// <summary>
                    /// <para>文本内容</para>
                    /// </summary>
                    public record ReplyElementPerson
                    {
                        /// <summary>
                        /// <para>回复 at 联系人</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string UserId { get; set; } = string.Empty;
                    }
                }
            }

            /// <summary>
            /// <para>回复 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6916106822734512356</para>
            /// </summary>
            [JsonPropertyName("reply_id")]
            public string? ReplyId { get; set; }

            /// <summary>
            /// <para>用户 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eab2abcef</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1610281603</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1610281603</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>回复的其他内容，图片 Token 等</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("extra")]
            public ReplyExtra? Extra { get; set; }

            /// <summary>
            /// <para>回复的其他内容，图片 Token 等</para>
            /// </summary>
            public record ReplyExtra
            {
                /// <summary>
                /// <para>评论中的图片 Token list</para>
                /// <para>必填：否</para>
                /// <para>示例值：["xfsfseewewabcef"]</para>
                /// </summary>
                [JsonPropertyName("image_list")]
                public string[]? ImageList { get; set; }
            }
        }
    }
}
