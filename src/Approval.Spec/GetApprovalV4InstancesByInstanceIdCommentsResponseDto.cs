using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 获取评论 响应体
/// <para>根据 Instance Code 获取某个审批实例下的全部评论与评论回复（不包含审批同意、拒绝、转交等附加的理由或意见）。</para>
/// <para>接口ID：7117964632137236483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2flist</para>
/// </summary>
public record GetApprovalV4InstancesByInstanceIdCommentsResponseDto
{
    /// <summary>
    /// <para>评论数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comments")]
    public Comment[]? Comments { get; set; }

    /// <summary></summary>
    public record Comment
    {
        /// <summary>
        /// <para>评论ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>评论创建时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>评论更新时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>是否删除，0:未删除，1:已删除</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("is_delete")]
        public int? IsDelete { get; set; }

        /// <summary>
        /// <para>评论的回复</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("replies")]
        public CommentReply[]? Replies { get; set; }

        /// <summary></summary>
        public record CommentReply
        {
            /// <summary>
            /// <para>评论ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>评论内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>评论创建时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>评论更新时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>是否删除，0:未删除，1:已删除</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("is_delete")]
            public int? IsDelete { get; set; }

            /// <summary>
            /// <para>评论中艾特人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("at_info_list")]
            public CommentAtInfo[]? AtInfoList { get; set; }

            /// <summary>
            /// <para>评论创建人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("commentator")]
            public string? Commentator { get; set; }

            /// <summary>
            /// <para>附加字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("extra")]
            public string? Extra { get; set; }
        }

        /// <summary></summary>
        public record CommentAtInfo
        {
            /// <summary>
            /// <para>被艾特人的ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>被艾特人的姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>被艾特人在评论中的位置，从0开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("offset")]
            public string? Offset { get; set; }
        }

        /// <summary>
        /// <para>评论中艾特人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("at_info_list")]
        public CommentAtInfo[]? AtInfoList { get; set; }

        /// <summary>
        /// <para>评论创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("commentator")]
        public string? Commentator { get; set; }

        /// <summary>
        /// <para>附加字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("extra")]
        public string? Extra { get; set; }
    }
}
