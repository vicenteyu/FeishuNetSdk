using Newtonsoft.Json;
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期任务（指定用户） 请求体
/// <para>获取指定周期的指定用户的任务信息</para>
/// <para>接口ID：7275704938197221378</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/stage_task/find_by_user_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_user_list</para>
/// </summary>
public record PostPerformanceV1StageTasksFindByUserListBodyDto
{
    /// <summary>
    /// <para>周期 ID。1 次只允许查询 1 个周期。可以通过「获取周期」接口获得周期 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7033710017401751071</para>
    /// </summary>
    [JsonProperty("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户 ID 列表，如果以用户身份访问，该值仅能填写本人 ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("user_id_lists")]
    public string[] UserIdLists { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>任务分类（不传默认包含所有）</para>
    /// <para>1. 待完成</para>
    /// <para>2. 已完成</para>
    /// <para>3. 已逾期（仅当租户设置不允许逾期提交时才有此分类）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：3</para>
    /// </summary>
    [JsonProperty("task_option_lists")]
    public int[]? TaskOptionLists { get; set; }

    /// <summary>
    /// <para>查询在此时间之后截止的环节</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonProperty("after_time")]
    public string? AfterTime { get; set; }

    /// <summary>
    /// <para>查询在此时间之前截止的环节</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonProperty("before_time")]
    public string? BeforeTime { get; set; }
}
