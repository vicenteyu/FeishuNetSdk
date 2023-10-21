using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取简历评估信息 响应体
/// <para>获取简历评估信息。</para>
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
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>简历评估信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
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
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6875569957036738823</para>
        /// </summary>
        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>投递阶段</para>
        /// <para>必填：否</para>
        /// <para>示例值：6784315427607595268</para>
        /// </summary>
        [JsonProperty("stage_id")]
        public string? StageId { get; set; }

        /// <summary>
        /// <para>创建人user_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
        /// </summary>
        [JsonProperty("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>评估人user_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
        /// </summary>
        [JsonProperty("evaluator_id")]
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
        [JsonProperty("commit_status")]
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
        [JsonProperty("conclusion")]
        public int? Conclusion { get; set; }

        /// <summary>
        /// <para>评估详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：这位同学很优秀</para>
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1600843767338</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>最近更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1600843937733</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }
    }
}
