// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV2ProbationAssessmentsByAssessmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新试用期考核信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新试用期考核信息 请求体
/// <para>更新试用期的考核结果</para>
/// <para>接口ID：7254814386694602754</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation-assessment%2fpatch</para>
/// </summary>
public record PatchCorehrV2ProbationAssessmentsByAssessmentIdBodyDto
{
    /// <summary>
    /// <para>考核状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：completed</para>
    /// <para>可选值：<list type="bullet">
    /// <item>not_started：未开始</item>
    /// <item>in_process：进行中</item>
    /// <item>completed：已完成</item>
    /// <item>no_need：无需考核</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("assessment_status")]
    public string AssessmentStatus { get; set; } = string.Empty;

    /// <summary>
    /// <para>试用期考核结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：approved</para>
    /// <para>可选值：<list type="bullet">
    /// <item>approved：通过</item>
    /// <item>rejected：不通过</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("assessment_result")]
    public string? AssessmentResult { get; set; }

    /// <summary>
    /// <para>考核得分</para>
    /// <para>必填：否</para>
    /// <para>示例值：99.9</para>
    /// </summary>
    [JsonPropertyName("assessment_score")]
    public float? AssessmentScore { get; set; }

    /// <summary>
    /// <para>试用期考核等级，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "probation_management"</para>
    /// <para>- custom_api_name = "final_assessment_grade"</para>
    /// <para>必填：否</para>
    /// <para>示例值：grade_a</para>
    /// </summary>
    [JsonPropertyName("assessment_grade")]
    public string? AssessmentGrade { get; set; }

    /// <summary>
    /// <para>考核评语</para>
    /// <para>必填：否</para>
    /// <para>示例值：超出预期</para>
    /// </summary>
    [JsonPropertyName("assessment_comment")]
    public string? AssessmentComment { get; set; }

    /// <summary>
    /// <para>考核结果页面超链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：暂无示例</para>
    /// </summary>
    [JsonPropertyName("assessment_detail")]
    public string? AssessmentDetail { get; set; }

    /// <summary>
    /// <para>是否为最终考核结果</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_final_asssessment")]
    public bool IsFinalAsssessment { get; set; }
}
