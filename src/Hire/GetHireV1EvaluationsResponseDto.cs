// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1EvaluationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取简历评估信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 批量获取简历评估信息 响应体
/// <para>批量获取简历评估信息，包含评估人、评估结论、评估详情等信息。支持按照投递 ID、更新时间来进行筛选。</para>
/// <para>接口ID：7062626037662892033</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/evaluation/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fevaluation%2flist</para>
/// </summary>
public record GetHireV1EvaluationsResponseDto
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
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>简历评估信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Evaluation[]? Items { get; set; }

    /// <summary>
    /// <para>简历评估信息列表</para>
    /// </summary>
    public record Evaluation
    {
        /// <summary>
        /// <para>评估 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6875295756292425998</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6875569957036738823</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>投递阶段 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)接口返回结果中 `data.items.stage_list` 字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：6784315427607595268</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        public string? StageId { get; set; }

        /// <summary>
        /// <para>创建人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>评估人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
        /// </summary>
        [JsonPropertyName("evaluator_id")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// <para>提交状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已提交</item>
        /// <item>2：未提交</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("commit_status")]
        public int? CommitStatus { get; set; }

        /// <summary>
        /// <para>评估结论</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：通过</item>
        /// <item>2：未通过</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("conclusion")]
        public int? Conclusion { get; set; }

        /// <summary>
        /// <para>评估详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：这位同学很优秀</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>简历评估创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1600843767338</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>简历评估更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1600843937733</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }
}
