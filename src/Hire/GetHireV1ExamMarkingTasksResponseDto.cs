// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1ExamMarkingTasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取员工笔试阅卷任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取员工笔试阅卷任务 响应体
/// <para>查询员工笔试阅卷任务。根据 page_token 与 page_size 进行游标分页查询，能查询到的信息包括：笔试ID、职位ID、人才ID、投递ID、任务状态。查询到的信息可应用于提醒员工完成笔试阅卷任务等场景</para>
/// <para>接口ID：7096308827411120129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/recruitment-process-follow-up/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam_marking_task%2flist</para>
/// </summary>
public record GetHireV1ExamMarkingTasksResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ExamMarkingTask[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record ExamMarkingTask
    {
        /// <summary>
        /// <para>笔试 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897921873523247373</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>人才 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7046263097923537196</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7046315599510833452</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：待阅卷</item>
        /// <item>2：已阅卷</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("activity_status")]
        public int? ActivityStatus { get; set; }
    }
}
