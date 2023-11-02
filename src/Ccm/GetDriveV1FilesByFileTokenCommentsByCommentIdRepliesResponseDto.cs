using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取回复 响应体
/// <para>该接口用于根据评论 ID 以及分页参数，获取回复。</para>
/// <para>接口ID：7123144042921607170</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2flist</para>
/// </summary>
public record GetDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto
{
    /// <summary>
    /// <para>回复列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public FileCommentReply[]? Items { get; set; }

    /// <summary>
    /// <para>回复列表</para>
    /// </summary>
    public record FileCommentReply
    {
        /// <summary>
        /// <para>回复ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6916106822734512356</para>
        /// </summary>
        [JsonProperty("reply_id")]
        public string? ReplyId { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eab2abcef</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610281603</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610281603</para>
        /// </summary>
        [JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// <para>回复内容</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("content")]
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
            [JsonProperty("elements")]
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
                [JsonProperty("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("text_run")]
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
                    [JsonProperty("text")]
                    public string Text { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("docs_link")]
                public ReplyElementDocsLink? DocsLink { get; set; }

                /// <summary>
                /// <para>文本内容</para>
                /// </summary>
                public record ReplyElementDocsLink
                {
                    /// <summary>
                    /// <para>回复 at云文档</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef</para>
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("person")]
                public ReplyElementPerson? Person { get; set; }

                /// <summary>
                /// <para>文本内容</para>
                /// </summary>
                public record ReplyElementPerson
                {
                    /// <summary>
                    /// <para>回复 at联系人</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
                    /// </summary>
                    [JsonProperty("user_id")]
                    public string UserId { get; set; } = string.Empty;
                }
            }
        }

        /// <summary>
        /// <para>回复的其他内容，图片token等</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("extra")]
        public ReplyExtra? Extra { get; set; }

        /// <summary>
        /// <para>回复的其他内容，图片token等</para>
        /// </summary>
        public record ReplyExtra
        {
            /// <summary>
            /// <para>评论中的图片token list</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("image_list")]
            public string[]? ImageList { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916106822734512356</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool HasMore { get; set; }
}
