namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期任务（全部用户） 请求体
/// <para>可按分页获取周期下所有用户的任务信息</para>
/// <para>接口ID：7275704938197237762</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/stage_task/find_by_page</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_page</para>
/// </summary>
public record PostPerformanceV1StageTasksFindByPageBodyDto
{
    /// <summary>
    /// <para>周期 ID。1 次只允许查询 1 个周期。可以通过「获取周期」接口获得周期 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7033710017401751071</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务分类（不传默认包含所有）</para>
    /// <para>1. 待完成</para>
    /// <para>2. 已完成</para>
    /// <para>3. 已逾期（仅当租户设置不允许逾期提交时才有此分类）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：3</para>
    /// </summary>
    [JsonPropertyName("task_option_lists")]
    public int[]? TaskOptionLists { get; set; }

    /// <summary>
    /// <para>查询在此时间之后截止的环节</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("after_time")]
    public string? AfterTime { get; set; }

    /// <summary>
    /// <para>查询早于当前时间截止的环节</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("before_time")]
    public string? BeforeTime { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：否</para>
    /// <para>示例值：30</para>
    /// <para>默认值：20</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }
}
