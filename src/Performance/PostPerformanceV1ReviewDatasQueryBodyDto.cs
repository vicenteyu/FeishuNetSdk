namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效结果 请求体
/// <para>获取绩效结果</para>
/// <para>接口ID：7000193886257725441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/performance-v1/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2freview_data%2fquery</para>
/// </summary>
public record PostPerformanceV1ReviewDatasQueryBodyDto
{
    /// <summary>
    /// <para>查询范围的开始日期，毫秒级时间戳，开始日期不能晚于截止日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：1430425599999</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询范围的截止日期，毫秒级时间戳，截止日期不能早于开始日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>环节类型。目前仅支持终评环节、结果沟通环节、查看绩效结果环节（不传默认包含所有的环节）</para>
    /// <para>必填：是</para>
    /// <para>示例值：["leader_review","communication_and_open_result"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("stage_types")]
    public string[] StageTypes { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查看绩效结果环节状态（不传默认包含所有的状态）</para>
    /// <para>**可选值有**：</para>
    /// <para>- `0`：已开通，绩效结果已开通，未发起复议也无需确认结果</para>
    /// <para>- `1`：待确认，绩效结果已开通但被评估人还未确认结果，确认的截止时间还未到达</para>
    /// <para>- `2`：已截止，绩效结果已开通但被评估人还未确认结果，确认的截止时间已到达</para>
    /// <para>- `3`：已确认，绩效结果已开通，被评估人已确认结果</para>
    /// <para>- `4`：已复议，绩效结果已开通，且被评估人已发起复议</para>
    /// <para>终评环节/结果沟通环节状态（不传默认包含所有的状态）</para>
    /// <para>&lt;!--</para>
    /// <para>必填：否</para>
    /// <para>示例值：[0,1,2,3]--&gt;</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("stage_progress")]
    public int[]? StageProgress { get; set; }

    /// <summary>
    /// <para>--&gt;</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大长度：`50`</para>
    /// <para>&lt;/md-dt-td&gt;</para>
    /// <para>&lt;/md-dt-tr&gt;</para>
    /// <para>&lt;md-dt-tr level="0"&gt;</para>
    /// <para>&lt;md-dt-td&gt;</para>
    /// <para>&lt;md-text type="field-name" &gt;semester_id_list&lt;/md-text&gt;</para>
    /// <para>&lt;/md-dt-td&gt;</para>
    /// <para>&lt;md-dt-td&gt;</para>
    /// <para>&lt;md-text type="field-type" &gt;string\[\]&lt;/md-text&gt;</para>
    /// <para>&lt;/md-dt-td&gt;</para>
    /// <para>&lt;md-dt-td&gt;</para>
    /// <para>否</para>
    /// <para>&lt;/md-dt-td&gt;</para>
    /// <para>&lt;md-dt-td&gt;</para>
    /// <para>评估周期 ID 列表，semester_id 是一个评估周期的唯一标识，可以通过「我的评估」页面 url 获取，也可通过本接口的返回值获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["6992035450862224940"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("semester_id_list")]
    public string[]? SemesterIdList { get; set; }

    /// <summary>
    /// <para>被评估人 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["ou_3245842393d09e9428ad4655da6e30b3"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_id_list")]
    public string[] RevieweeUserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>环节更新时间晚于，可筛选出在此时间之后，有内容提交的环节数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("updated_later_than")]
    public string? UpdatedLaterThan { get; set; }
}
