// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCommentsBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量获取评论 响应体
/// <para>该接口用于根据评论 ID 列表批量获取云文档评论信息，包括评论和回复 ID、回复的内容、评论人和回复人的用户 ID 等。支持返回全局评论以及局部评论，可通过 is_whole （是否为全局评论标识）字段区分。</para>
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
    [JsonPropertyName("items")]
    public FileComment[]? Items { get; set; }

    /// <summary>
    /// <para>评论的相关信息、回复的信息、回复分页的信息</para>
    /// </summary>
    public record FileComment
    {
        /// <summary>
        /// <para>评论 ID</para>
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
        /// <para>创建时间（单位：秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610281603</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间（单位：秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610281603</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>是否已解决</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_solved")]
        public bool? IsSolved { get; set; }

        /// <summary>
        /// <para>解决评论时间（单位：秒）</para>
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
        /// <para>是否有更多回复</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>回复分页标记</para>
        /// <para>必填：否</para>
        /// <para>示例值：6916106822734512356</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// <para>是否是全文评论</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_whole")]
        public bool? IsWhole { get; set; }

        /// <summary>
        /// <para>局部评论的引用字段</para>
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
        public ReplyListSuffix? ReplyList { get; set; }

        /// <summary>
        /// <para>评论里的回复列表</para>
        /// </summary>
        public record ReplyListSuffix
        {
            /// <summary>
            /// <para>回复列表</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("replies")]
            public FileCommentReply[] Replies { get; set; } = [];

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
                    public ReplyElement[] Elements { get; set; } = [];

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
                        public TextRunSuffix? TextRun { get; set; }

                        /// <summary>
                        /// <para>文本内容</para>
                        /// </summary>
                        public record TextRunSuffix
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
                        /// <para>添加云文档链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("docs_link")]
                        public DocsLinkSuffix? DocsLink { get; set; }

                        /// <summary>
                        /// <para>添加云文档链接</para>
                        /// </summary>
                        public record DocsLinkSuffix
                        {
                            /// <summary>
                            /// <para>回复 at 云文档</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：null</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>添加用户的 user_id</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("person")]
                        public PersonSuffix? Person { get; set; }

                        /// <summary>
                        /// <para>添加用户的 user_id</para>
                        /// </summary>
                        public record PersonSuffix
                        {
                            /// <summary>
                            /// <para>添加用户的 user_id 以@用户</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：null</para>
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
                /// <para>创建时间（单位：秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1610281603</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>更新时间（单位：秒）</para>
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
                    /// </summary>
                    [JsonPropertyName("image_list")]
                    public string[]? ImageList { get; set; }
                }

                /// <summary>
                /// <para>评论回复卡片上对应的表情回复信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reactions")]
                public FileCommentV2BatchQueryReactionData[]? Reactions { get; set; }

                /// <summary>
                /// <para>评论回复卡片上对应的表情回复信息</para>
                /// </summary>
                public record FileCommentV2BatchQueryReactionData
                {
                    /// <summary>
                    /// <para>表情回复的唯一标识，用于区分不同类型的评论表情（如点赞、鼓掌等）。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ANGRY</para>
                    /// <para>最大长度：100</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("reaction_key")]
                    public string ReactionKey { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>该表情回复的累计使用次数，统计范围为当前评论下所有用户的有效回复记录。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：10</para>
                    /// <para>最大值：500000</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("count")]
                    public int Count { get; set; }

                    /// <summary>
                    /// <para>用于在界面优先展示核心互动用户。用户ID可通过用户信息查询接口获取。</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：1000</para>
                    /// <para>最小长度：1</para>
                    /// </summary>
                    [JsonPropertyName("ahead_users")]
                    public string[]? AheadUsers { get; set; }
                }
            }
        }
    }
}
