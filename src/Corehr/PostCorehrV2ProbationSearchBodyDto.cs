// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2ProbationSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索试用期信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索试用期信息 请求体
/// <para>搜索试用期信息，创建试用期后立刻搜索，可能会存在 5s 左右延迟</para>
/// <para>接口ID：7254814386694553602</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsearch</para>
/// </summary>
public record PostCorehrV2ProbationSearchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID 列表，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>部门 ID 列表，可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>试用期开始日期 - 搜索范围开始，需要与搜索范围结束一同使用，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-18</para>
    /// </summary>
    [JsonPropertyName("probation_start_date_start")]
    public string? ProbationStartDateStart { get; set; }

    /// <summary>
    /// <para>试用期开始日期 - 搜索范围结束，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-20</para>
    /// </summary>
    [JsonPropertyName("probation_start_date_end")]
    public string? ProbationStartDateEnd { get; set; }

    /// <summary>
    /// <para>试用期预计结束日期 - 搜索范围开始，需要与搜索范围结束一同使用，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-06-20</para>
    /// </summary>
    [JsonPropertyName("probation_expected_end_date_start")]
    public string? ProbationExpectedEndDateStart { get; set; }

    /// <summary>
    /// <para>试用期预计结束日期 - 搜索范围结束，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-07-20</para>
    /// </summary>
    [JsonPropertyName("probation_expected_end_date_end")]
    public string? ProbationExpectedEndDateEnd { get; set; }

    /// <summary>
    /// <para>试用期实际结束日期 - 搜索范围开始，需要与搜索范围结束一同使用，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-08-20</para>
    /// </summary>
    [JsonPropertyName("actual_probation_end_date_start")]
    public string? ActualProbationEndDateStart { get; set; }

    /// <summary>
    /// <para>试用期实际结束日期 - 搜索范围结束，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-09-20</para>
    /// </summary>
    [JsonPropertyName("actual_probation_end_date_end")]
    public string? ActualProbationEndDateEnd { get; set; }

    /// <summary>
    /// <para>转正发起日期 - 搜索范围开始，需要与搜索范围结束一同使用，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-10-20</para>
    /// </summary>
    [JsonPropertyName("initiating_time_start")]
    public string? InitiatingTimeStart { get; set; }

    /// <summary>
    /// <para>转正发起日期 - 搜索范围结束，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-11-20</para>
    /// </summary>
    [JsonPropertyName("initiating_time_end")]
    public string? InitiatingTimeEnd { get; set; }

    /// <summary>
    /// <para>试用期状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：approved</para>
    /// <para>可选值：<list type="bullet">
    /// <item>pending：审批中</item>
    /// <item>rejected：已拒绝</item>
    /// <item>waiting：待发起转正</item>
    /// <item>approved：审批通过</item>
    /// <item>converted：已转正</item>
    /// <item>offboarded：已离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("probation_status")]
    public string? ProbationStatus { get; set; }

    /// <summary>
    /// <para>试用期最终考核结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：approved</para>
    /// <para>可选值：<list type="bullet">
    /// <item>approved：通过</item>
    /// <item>rejected：不通过</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("final_assessment_result")]
    public string? FinalAssessmentResult { get; set; }

    /// <summary>
    /// <para>试用期最终考核等级，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：probation_management</para>
    /// <para>- custom_api_name：final_assessment_grade</para>
    /// <para>字段权限要求：</para>
    /// <para>按照试用期考核等级搜索 (corehr:probation.grade.search:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：grade_a</para>
    /// </summary>
    [JsonPropertyName("final_assessment_grade")]
    public string? FinalAssessmentGrade { get; set; }
}
