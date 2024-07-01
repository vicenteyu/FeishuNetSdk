// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2ReviewDatasQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取绩效详情数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效详情数据 请求体
/// <para>获取被评估人各环节的绩效评估详情（不包含校准环节），如环节评估数据、环节提交状态等</para>
/// <para>接口ID：7351374599659847684</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/review_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fquery</para>
/// </summary>
public record PostPerformanceV2ReviewDatasQueryBodyDto
{
    /// <summary>
    /// <para>评估周期 ID 列表，semester_id 可通过[【获取周期】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)获得</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("semester_ids")]
    public string[] SemesterIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>被评估人 ID 列表，ID 类型与user_id_type 的取值一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_ids")]
    public string[] RevieweeUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>环节类型，如果同时传了环节 ID 和环节类型，优先返回环节 ID 对应的绩效数据。不传默认不返回任何环节评估数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("stage_types")]
    public string[]? StageTypes { get; set; }

    /// <summary>
    /// <para>评估型环节的执行人角色，当传入的环节类型中有评估型环节时，该参数才生效，返回指定执行人角色的评估型环节数据，不传默认包含所有的执行人角色。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("review_stage_roles")]
    public string[]? ReviewStageRoles { get; set; }

    /// <summary>
    /// <para>环节 ID，如果同时传了环节 ID 和环节类型，优先返回环节 ID 对应的绩效数据。不传默认不返回任何环节评估数据。</para>
    /// <para>可在事件[绩效结果开通](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/stage_task/events/open_result)、[绩效详情变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/review_data/events/changed)获得，用于接收事件后按环节查询评估数据场景</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("stage_ids")]
    public string[]? StageIds { get; set; }

    /// <summary>
    /// <para>当要获取的绩效数据的环节类型包含终评环节时，可指定是否需要返回绩效终评数据的具体环节来源。不传则默认不返回。</para>
    /// <para>可选值有：</para>
    /// <para>- true: 返回绩效终评数据的具体环节来源</para>
    /// <para>- false: 不返回绩效终评数据的具体环节来源</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_leader_review_data_source")]
    public bool? NeedLeaderReviewDataSource { get; set; }

    /// <summary>
    /// <para>可筛选出在此时间之后，有内容提交的环节数据，毫秒级时间戳。不传默认返回所有时间提交的环节数据，包括未提交的环节数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("updated_later_than")]
    public string? UpdatedLaterThan { get; set; }

    /// <summary>
    /// <para>环节状态，不传默认包含所有状态。各类型的环节分别有以下环节状态：</para>
    /// <para>查看绩效结果环节状态</para>
    /// <para>可选值有：</para>
    /// <para>- `0`：已开通，绩效结果已开通，未发起复议也无需确认结果</para>
    /// <para>- `1`：待确认，绩效结果已开通但被评估人还未确认结果，确认的截止时间还未到达</para>
    /// <para>- `2`：已截止，绩效结果已开通但被评估人还未确认结果，确认的截止时间已到达</para>
    /// <para>- `3`：已确认，绩效结果已开通，被评估人已确认结果</para>
    /// <para>- `4`：已复议，绩效结果已开通，且被评估人已发起复议</para>
    /// <para>绩效结果复议环节状态</para>
    /// <para>可选值有：</para>
    /// <para>- `1`：待完成，任务未完成</para>
    /// <para>- `2`：已截止，任务的截止时间已到达，且任务未完成</para>
    /// <para>- `3`：已完成，任务已完成</para>
    /// <para>除上述类型外的其他环节类型状态</para>
    /// <para>可选值有：</para>
    /// <para>- `0`：未开始，任务的开始时间未到达</para>
    /// <para>- `1`：待完成，任务的开始时间到达而截止时间未到达，且任务未完成</para>
    /// <para>- `2`：已截止，任务的截止时间已到达，且任务未完成</para>
    /// <para>- `3`: 已完成，任务已完成</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("stage_progresses")]
    public int[]? StageProgresses { get; set; }
}
