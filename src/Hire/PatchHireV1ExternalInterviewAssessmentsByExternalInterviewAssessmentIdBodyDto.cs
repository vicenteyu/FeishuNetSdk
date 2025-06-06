// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PatchHireV1ExternalInterviewAssessmentsByExternalInterviewAssessmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新外部面评 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新外部面评 请求体
/// <para>更新外部面评部分字段，没有填写的字段不会被更新</para>
/// <para>接口ID：7270722035910328322</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-interview-info/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview_assessment%2fpatch</para>
/// </summary>
public record PatchHireV1ExternalInterviewAssessmentsByExternalInterviewAssessmentIdBodyDto
{
    /// <summary>
    /// <para>面试官姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：shaojiale</para>
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// <para>面试结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：不通过</item>
    /// <item>2：通过</item>
    /// <item>3：待定</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("conclusion")]
    public int? Conclusion { get; set; }

    /// <summary>
    /// <para>评价维度列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assessment_dimension_list")]
    public ExternalInterviewAssessmentDimension[]? AssessmentDimensionLists { get; set; }

    /// <summary>
    /// <para>评价维度列表</para>
    /// </summary>
    public record ExternalInterviewAssessmentDimension
    {
        /// <summary>
        /// <para>打分题分数（当题目类型为「打分题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：99</para>
        /// </summary>
        [JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// <para>单选选项（当题目类型为「单选题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：opt</para>
        /// </summary>
        [JsonPropertyName("option")]
        public string? Option { get; set; }

        /// <summary>
        /// <para>多选选项（当题目类型为「多选题」时使用）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public string[]? Options { get; set; }

        /// <summary>
        /// <para>描述内容（当题目类型为「描述题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：content</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>题目类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：打分题</item>
        /// <item>2：单选题</item>
        /// <item>3：描述题</item>
        /// <item>4：多选题</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("assessment_type")]
        public int? AssessmentType { get; set; }

        /// <summary>
        /// <para>题目标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>题目描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：desc</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// <para>综合记录</para>
    /// <para>必填：否</para>
    /// <para>示例值：hello world</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
