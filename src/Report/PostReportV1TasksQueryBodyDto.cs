namespace FeishuNetSdk.Report;
/// <summary>
/// 查询任务 请求体
/// <para>查询任务。</para>
/// <para>接口ID：6969187588792369180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2ftask%2fquery</para>
/// </summary>
public record PostReportV1TasksQueryBodyDto
{
    /// <summary>
    /// <para>提交开始时间时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1622427266</para>
    /// </summary>
    [JsonPropertyName("commit_start_time")]
    public int CommitStartTime { get; set; }

    /// <summary>
    /// <para>提交结束时间时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1622427266</para>
    /// </summary>
    [JsonPropertyName("commit_end_time")]
    public int CommitEndTime { get; set; }

    /// <summary>
    /// <para>汇报规则ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6894419345318182932</para>
    /// </summary>
    [JsonPropertyName("rule_id")]
    public string? RuleId { get; set; }

    /// <summary>
    /// <para>用户ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_133f0b6d0f097cf7d7ba00b38fffb110</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：是</para>
    /// <para>示例值：6895699275733778451</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>单次分页返回的条数</para>
    /// <para>必填：是</para>
    /// <para>示例值：10</para>
    /// <para>最大值：20</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }
}
