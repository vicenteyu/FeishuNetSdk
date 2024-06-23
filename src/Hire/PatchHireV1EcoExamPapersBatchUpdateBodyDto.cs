// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHireV1EcoExamPapersBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新试卷 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新试卷 请求体
/// <para>更新指定帐号可用的试卷列表</para>
/// <para>接口ID：7195815979079532545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fbatch_update</para>
/// </summary>
public record PatchHireV1EcoExamPapersBatchUpdateBodyDto
{
    /// <summary>
    /// <para>账号 ID，可在「账号绑定」事件中获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7147998241542539527</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试卷列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("paper_list")]
    public EcoExamPaperData[] PaperLists { get; set; } = Array.Empty<EcoExamPaperData>();

    /// <summary>
    /// <para>试卷列表</para>
    /// </summary>
    public record EcoExamPaperData
    {
        /// <summary>
        /// <para>试卷 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7147998241542539527</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>试卷名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：春季测评</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>考试时长（分钟）</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>试卷题目数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("question_count")]
        public int? QuestionCount { get; set; }

        /// <summary>
        /// <para>开始时间，留空或不传表示不限制开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1658676234053</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间，留空或不传表示不限制结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1672444800000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }
}
