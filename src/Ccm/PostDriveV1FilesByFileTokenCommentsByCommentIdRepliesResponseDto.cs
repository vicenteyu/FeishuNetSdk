// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加回复 响应体
/// <para>使用该接口可对云文档中的某条评论进行回复，回复内容支持普通文本、云文档链接等。</para>
/// <para>接口ID：7625922449226419390</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto
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
        public ReplyElement[] Elements { get; set; } = [];

        /// <summary>
        /// <para>回复内容的元素列表</para>
        /// </summary>
        public record ReplyElement
        {
            /// <summary>
            /// <para>回复内容的元素类型</para>
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
                /// <para>必填：是</para>
                /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eab2abcef</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string UserId { get; set; } = string.Empty;
            }
        }
    }

    /// <summary>
    /// <para>回复 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916106xxxxx4512356</para>
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
        /// <para>回复中的图片 Token list</para>
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
        /// <para>示例值：like</para>
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
