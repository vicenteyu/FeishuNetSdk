using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 创建评论 请求体
/// <para>在某审批实例下创建、修改评论或评论回复（不包含审批同意、拒绝、转交等附加的理由或意见）。</para>
/// <para>接口ID：7117964632137154563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesByInstanceIdCommentsBodyDto
{
    /// <summary>
    /// <para>评论内容，包含艾特人、附件等</para>
    /// <para>**示例值**："{\"text\":\"来自小程序的评论111我带附件中有extra \",\"files\":[{\"url\":\"xxx\",\"fileSize\":155149,\"title\":\"9a9fedc5cfb01a4a20c715098.png\",\"type\":\"image\",\"extra\":\"\"}]}"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>评论中艾特人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("at_info_list")]
    public CommentAtInfo[]? AtInfoList { get; set; }

    /// <summary></summary>
    public record CommentAtInfo
    {
        /// <summary>
        /// <para>被艾特人的ID</para>
        /// <para>**示例值**："579fd9c4"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>被艾特人的姓名</para>
        /// <para>**示例值**："张某"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>被艾特人在评论中的位置，从0开始</para>
        /// <para>**示例值**："1"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("offset")]
        public string Offset { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>父评论ID，如果是回复评论，需要传</para>
    /// <para>**示例值**："7081516627711524883"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("parent_comment_id")]
    public string? ParentCommentId { get; set; }

    /// <summary>
    /// <para>评论ID，如果是编辑、删除一条评论，需要传</para>
    /// <para>**示例值**："7081516627711524883"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>disable_bot=true只同步数据，不触发bot</para>
    /// <para>**示例值**：false</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("disable_bot")]
    public bool? DisableBot { get; set; }

    /// <summary>
    /// <para>附加字段</para>
    /// <para>**示例值**："{\"a\":\"a\"}"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("extra")]
    public string? Extra { get; set; }
}
