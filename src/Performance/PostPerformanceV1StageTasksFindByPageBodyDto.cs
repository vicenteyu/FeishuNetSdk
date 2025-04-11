// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPerformanceV1StageTasksFindByPageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取周期任务（全部用户） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期任务（全部用户） 请求体
/// <para>批量获取周期下所有用户的任务信息。支持传入任务分类、任务截止时间参数删选周期内任务数据。</para>
/// <para>接口ID：7275704938197237762</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/stage_task/find_by_page</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_page</para>
/// </summary>
public record PostPerformanceV1StageTasksFindByPageBodyDto
{
    /// <summary>
    /// <para>周期 ID，可通过[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7033710017401751071</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务分类，填写则获取指定分类的任务</para>
    /// <para>**可选项有**：</para>
    /// <para>- `1`：待完成</para>
    /// <para>- `2`：已完成</para>
    /// <para>- `3`：已逾期（仅当租户设置不允许逾期提交时才有此分类）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：3</para>
    /// </summary>
    [JsonPropertyName("task_option_lists")]
    public int[]? TaskOptionLists { get; set; }

    /// <summary>
    /// <para>任务截止时间最小值，毫秒时间戳，填写则查询在此时间之后截止的任务</para>
    /// <para>必填：否</para>
    /// <para>示例值：1630425599999</para>
    /// </summary>
    [JsonPropertyName("after_time")]
    public string? AfterTime { get; set; }

    /// <summary>
    /// <para>任务截止时间最大值，毫秒时间戳，填写则查询在此时间之前截止的任务</para>
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
    /// <para>最大值：50</para>
    /// <para>默认值：20</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }
}
