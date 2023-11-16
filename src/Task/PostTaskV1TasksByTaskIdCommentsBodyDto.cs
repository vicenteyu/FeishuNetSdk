namespace FeishuNetSdk.Task;
/// <summary>
/// 创建评论 请求体
/// <para>该接口用于创建和回复任务的评论。当parent_id字段为0时，为创建评论；当parent_id不为0时，为回复某条评论。</para>
/// <para>接口ID：6999599891686293506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fcreate</para>
/// </summary>
public record PostTaskV1TasksByTaskIdCommentsBodyDto
{
    /// <summary>
    /// <para>评论内容。</para>
    /// <para>评论内容和富文本评论内容同时存在时只使用富文本评论内容。</para>
    /// <para>必填：否</para>
    /// <para>示例值：举杯邀明月，对影成三人</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>评论的父ID，创建评论时若不为空则为某条评论的回复，若为空则不是回复</para>
    /// <para>必填：否</para>
    /// <para>示例值：6937231762296684564</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>评论创建的时间戳，单位为毫秒，用于展示，创建时不用填写</para>
    /// <para>必填：否</para>
    /// <para>示例值：1657075055135</para>
    /// </summary>
    [JsonPropertyName("create_milli_time")]
    public string? CreateMilliTime { get; set; }

    /// <summary>
    /// <para>富文本评论内容。语法格式参见[Markdown模块](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/markdown-module)</para>
    /// <para>必填：否</para>
    /// <para>示例值：举杯邀明月，对影成三人&lt;atid=7058204817822318612&gt;&lt;/at&gt;</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonPropertyName("rich_content")]
    public string? RichContent { get; set; }
}
