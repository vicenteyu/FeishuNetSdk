namespace FeishuNetSdk.Moments;
/// <summary>
/// 查询帖子信息 响应体
/// <para>通过 ID 查询帖子实体数据信息</para>
/// <para>接口ID：7270433540692639747</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/moments-v1/post/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost%2fget</para>
/// </summary>
public record GetMomentsV1PostsByPostIdResponseDto
{
    /// <summary>
    /// <para>帖子实体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("post")]
    public GetMomentsV1PostsByPostIdResponseDtoPost? Post { get; set; }

    /// <summary>
    /// <para>帖子实体</para>
    /// </summary>
    public record GetMomentsV1PostsByPostIdResponseDtoPost
    {
        /// <summary>
        /// <para>发帖用户ID（类型为请求中传入的类型，仅实名下有值）</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxx</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>帖子内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：[[{\"tag\":\"text\",\"text\":\"豪华中型车…………\"},{\"tag\":\"a\",\"text\":\"查看原文\",\"href\":\"https://www.autohome.com.cn/advice/202204/1244455.html\"}]]</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>图片的 key列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image_key_list")]
        public string[]? ImageKeyList { get; set; }

        /// <summary>
        /// <para>媒体文件的 token（暂未使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：该字段暂不支持使用</para>
        /// </summary>
        [JsonPropertyName("media_file_token")]
        public string? MediaFileToken { get; set; }

        /// <summary>
        /// <para>评论数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// <para>帖子的 reaction及其数量</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reaction_set")]
        public GetMomentsV1PostsByPostIdResponseDtoPostReactionSet? ReactionSet { get; set; }

        /// <summary>
        /// <para>帖子的 reaction及其数量</para>
        /// </summary>
        public record GetMomentsV1PostsByPostIdResponseDtoPostReactionSet
        {
            /// <summary>
            /// <para>reaction列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("reactions")]
            public ReactionList[]? Reactions { get; set; }

            /// <summary>
            /// <para>reaction列表</para>
            /// </summary>
            public record ReactionList
            {
                /// <summary>
                /// <para>reaction的类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：OK</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>该类型 reaction的数量</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("count")]
                public int? Count { get; set; }
            }

            /// <summary>
            /// <para>所有 reaction的数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("total_count")]
            public int? TotalCount { get; set; }
        }

        /// <summary>
        /// <para>帖子ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6934510454161014804</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>帖子创建时间，格式 rfc3339</para>
        /// <para>e.g. "2006-01-02T15:04:05Z07:00"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-23T00:00:00+08:00</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>视频封面图片（暂未使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：该字段暂不支持使用</para>
        /// </summary>
        [JsonPropertyName("media_cover_image_key")]
        public string? MediaCoverImageKey { get; set; }

        /// <summary>
        /// <para>帖子所属板块</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("category_ids")]
        public string[]? CategoryIds { get; set; }

        /// <summary>
        /// <para>帖子链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/moments/detail?postId=6934510454161014804</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>发帖人类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：实名</item>
        /// <item>2：花名</item>
        /// <item>3：匿名</item>
        /// <item>4：官方号</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }

        /// <summary>
        /// <para>点踩数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("dislike_count")]
        public int? DislikeCount { get; set; }
    }
}
