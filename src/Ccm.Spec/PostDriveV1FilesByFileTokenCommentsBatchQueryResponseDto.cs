using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 批量获取全文评论 响应体
/// <para>该接口用于根据评论 ID 列表批量获取全文评论，暂时不支持局部评论{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=drive&version=v1&resource=file.comment&method=batch_query)</para>
/// <para>接口ID：7123144042921590786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fbatch_query</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsBatchQueryResponseDto
{
    /// <summary>
    /// <para>评论的相关信息、回复的信息、回复分页的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public FileComment[]? Items { get; set; }

    public record FileComment
    {
        /// <summary>
        /// <para>评论ID（创建新评论可不填；如填写，则视为回复已有评论）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("comment_id")]
        public string? CommentId { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// <para>是否已解决</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("is_solved")]
        public bool? IsSolved { get; set; }

        /// <summary>
        /// <para>解决评论时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("solved_time")]
        public int? SolvedTime { get; set; }

        /// <summary>
        /// <para>解决评论者的用户ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("solver_user_id")]
        public string? SolverUserId { get; set; }

        /// <summary>
        /// <para>是否有更多回复</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>回复分页标记</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// <para>是否是全文评论</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("is_whole")]
        public bool? IsWhole { get; set; }

        /// <summary>
        /// <para>如果是局部评论，引用字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("quote")]
        public string? Quote { get; set; }

        /// <summary>
        /// <para>评论里的回复列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("reply_list")]
        public ReplyListSuffix? ReplyList { get; set; }

        public record ReplyListSuffix
        {
            /// <summary>
            /// <para>回复列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("replies")]
            public FileCommentReply[]? Replies { get; set; }

            public record FileCommentReply
            {
                /// <summary>
                /// <para>回复ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("reply_id")]
                public string? ReplyId { get; set; }

                /// <summary>
                /// <para>用户ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("user_id")]
                public string? UserId { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("create_time")]
                public int? CreateTime { get; set; }

                /// <summary>
                /// <para>更新时间</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("update_time")]
                public int? UpdateTime { get; set; }

                /// <summary>
                /// <para>回复内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("content")]
                public ReplyContent? Content { get; set; }

                public record ReplyContent
                {
                    /// <summary>
                    /// <para>回复的内容</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("elements")]
                    public ReplyElement[]? Elements { get; set; }

                    public record ReplyElement
                    {
                        /// <summary>
                        /// <para>回复的内容元素</para>
                        /// <para>**可选值有**：</para>
                        /// <para>text_run:普通文本,docs_link:at 云文档链接,person:at 联系人</para>
                        /// <para>必填：否</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>text_run：普通文本</item>
                        /// <item>docs_link：at云文档链接</item>
                        /// <item>person：at联系人</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("text_run")]
                        public TextRunSuffix? TextRun { get; set; }

                        public record TextRunSuffix
                        {
                            /// <summary>
                            /// <para>回复 普通文本</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonProperty("text")]
                            public string? Text { get; set; }
                        }

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("docs_link")]
                        public DocsLinkSuffix? DocsLink { get; set; }

                        public record DocsLinkSuffix
                        {
                            /// <summary>
                            /// <para>回复 at云文档</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string? Url { get; set; }
                        }

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("person")]
                        public PersonSuffix? Person { get; set; }

                        public record PersonSuffix
                        {
                            /// <summary>
                            /// <para>回复 at联系人</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonProperty("user_id")]
                            public string? UserId { get; set; }
                        }
                    }
                }

                /// <summary>
                /// <para>回复的其他内容，图片token等</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("extra")]
                public ReplyExtra? Extra { get; set; }

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
        }
    }
}
