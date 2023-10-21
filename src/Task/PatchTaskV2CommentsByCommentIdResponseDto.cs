using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新评论 响应体
/// <para>更新一条评论。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的评论的字段名，同时在`comment`字段中填写要修改的字段的新值即可。更新接口规范详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>目前只支持更新评论的"conent"字段。</para>
/// <para>接口ID：7255580838154420252</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fpatch</para>
/// </summary>
public record PatchTaskV2CommentsByCommentIdResponseDto
{
    /// <summary>
    /// <para>更新后的评论</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment")]
    public PatchTaskV2CommentsByCommentIdResponseDtoComment? Comment { get; set; }

    /// <summary>
    /// <para>更新后的评论</para>
    /// </summary>
    public record PatchTaskV2CommentsByCommentIdResponseDtoComment
    {
        /// <summary>
        /// <para>评论id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7197020628442939411</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：这是一条评论</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>评论创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>评论创建人</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：creator</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>被回复评论的id。如果不是回复评论，则为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7166825117308174356</para>
        /// <para>最大长度：30</para>
        /// </summary>
        [JsonProperty("reply_to_comment_id")]
        public string? ReplyToCommentId { get; set; }

        /// <summary>
        /// <para>评论创建时间戳（ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>评论更新时间戳（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>任务关联的资源类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：task</para>
        /// </summary>
        [JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>任务关联的资源ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ccb55625-95d2-2e80-655f-0e40bf67953f</para>
        /// </summary>
        [JsonProperty("resource_id")]
        public string? ResourceId { get; set; }
    }
}
