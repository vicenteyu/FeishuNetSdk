namespace FeishuNetSdk.Task;
/// <summary>
/// 创建评论 请求体
/// <para>为一个任务创建评论，或者回复该任务的某个评论。</para>
/// <para>若要创建一个回复评论，需要在创建时设置`reply_to_comment_id`字段。被回复的评论和新建的评论必须属于同一个任务。</para>
/// <para>接口ID：7255580838154616860</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fcreate</para>
/// </summary>
public record PostTaskV2CommentsBodyDto
{
    /// <summary>
    /// <para>评论内容。不允许为空，最长3000个utf8字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：这是一条评论。</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>回复给评论的评论ID。如果不填写表示创建非回复评论。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6937231762296684564</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("reply_to_comment_id")]
    public string? ReplyToCommentId { get; set; }

    /// <summary>
    /// <para>评论归属的资源类型，目前只支持任务“task”，默认为"task"。</para>
    /// <para>必填：否</para>
    /// <para>示例值：task</para>
    /// <para>默认值：task</para>
    /// </summary>
    [JsonPropertyName("resource_type")]
    public string? ResourceType { get; set; }

    /// <summary>
    /// <para>评论归属的资源ID。当归属资源类型为"task"时，这里应填写任务的GUID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ccb55625-95d2-2e80-655f-0e40bf67953f</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("resource_id")]
    public string? ResourceId { get; set; }
}
