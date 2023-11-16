namespace FeishuNetSdk.Task;
/// <summary>
/// 获取评论列表 响应体
/// <para>该接口用于查询任务评论列表，支持分页，最大值为100。</para>
/// <para>接口ID：7104611925149581315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2flist</para>
/// </summary>
public record GetTaskV1TasksByTaskIdCommentsResponseDto
{
    /// <summary>
    /// <para>返回的评论列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Comment[]? Items { get; set; }

    /// <summary>
    /// <para>返回的评论列表</para>
    /// </summary>
    public record Comment
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
        /// <para>评论ID，由飞书服务器发号</para>
        /// <para>必填：否</para>
        /// <para>示例值：6937231762296684564</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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

        /// <summary>
        /// <para>评论的创建者 ID。在创建评论时无需填充该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f346a</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
