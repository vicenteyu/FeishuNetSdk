// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPerformanceV1ReviewDatasQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取绩效结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效结果 请求体
/// <para>获取被评估人在指定周期、指定项目中各个环节的评估结果信息，包含绩效所在的周期、项目、评估项、评估模版以及各环节评估数据等信息。</para>
/// <para>接口ID：7000193886257725441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/performance-v1/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2freview_data%2fquery</para>
/// </summary>
public record PostPerformanceV1ReviewDatasQueryBodyDto
{
    /// <summary>
    /// <para>周期开始时间最小值，毫秒时间戳，小于该时间开始的周期会被过滤掉</para>
    /// <para>**注意**：当填写了 `semester_id_list` 参数时，此参数无效</para>
    /// <para>必填：是</para>
    /// <para>示例值：1430425599999</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>周期结束时间最大值，毫秒时间戳，大于该时间结束的周期会被过滤掉</para>
    /// <para>**注意**：当填写了 `semester_id_list` 参数时，此参数无效</para>
    /// <para>必填：是</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>环节类型，目前仅支持终评环节、结果沟通环节、查看绩效结果环节（不传默认包含所有的环节）</para>
    /// <para>必填：是</para>
    /// <para>示例值：["leader_review","communication_and_open_result"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("stage_types")]
    public string[] StageTypes { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>环节状态，填写时按照指定状态获取绩效结果，不填查询所有状态的绩效结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：[0,1,2,3]--&gt;</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("stage_progress")]
    public int[]? StageProgress { get; set; }

    /// <summary>
    /// <para>评估周期 ID 列表，可通过[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["6992035450862224940"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("semester_id_list")]
    public string[]? SemesterIdList { get; set; }

    /// <summary>
    /// <para>被评估人 ID 列表，与入参 `user_id_type` 类型一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：["ou_3245842393d09e9428ad4655da6e30b3"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_id_list")]
    public string[] RevieweeUserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>环节更新时间最早时间，毫秒时间戳，可筛选出在此时间之后，有内容提交的环节数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("updated_later_than")]
    public string? UpdatedLaterThan { get; set; }
}
