namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加全文评论 请求体
/// <para>在文档中添加一条全局评论，不支持局部评论。</para>
/// <para>接口ID：6955017385137750017</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsBodyDto
{
    /// <summary>
    /// <para>评论里的回复列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reply_list")]
    public PostDriveV1FilesByFileTokenCommentsBodyDtoReplyList? ReplyList { get; set; }

    /// <summary>
    /// <para>评论里的回复列表</para>
    /// </summary>
    public record PostDriveV1FilesByFileTokenCommentsBodyDtoReplyList
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
                /// <para>回复内容的元素列表</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("elements")]
                public ReplyElement[] Elements { get; set; } = Array.Empty<ReplyElement>();

                /// <summary>
                /// <para>回复内容的元素列表</para>
                /// </summary>
                public record ReplyElement
                {
                    /// <summary>
                    /// <para>回复内容的元素类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：text_run</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>text_run：普通文本</item>
                    /// <item>docs_link：云文档链接</item>
                    /// <item>person：at 联系人</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string Type { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>普通文本</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_run")]
                    public ReplyElementTextRun? TextRun { get; set; }

                    /// <summary>
                    /// <para>普通文本</para>
                    /// </summary>
                    public record ReplyElementTextRun
                    {
                        /// <summary>
                        /// <para>添加普通文本</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：comment text</para>
                        /// </summary>
                        [JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>云文档链接</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("docs_link")]
                    public ReplyElementDocsLink? DocsLink { get; set; }

                    /// <summary>
                    /// <para>云文档链接</para>
                    /// </summary>
                    public record ReplyElementDocsLink
                    {
                        /// <summary>
                        /// <para>添加云文档链接</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>at 联系人</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("person")]
                    public ReplyElementPerson? Person { get; set; }

                    /// <summary>
                    /// <para>at 联系人</para>
                    /// </summary>
                    public record ReplyElementPerson
                    {
                        /// <summary>
                        /// <para>添加用户的 user_id 以@用户</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string UserId { get; set; } = string.Empty;
                    }
                }
            }
        }
    }
}
