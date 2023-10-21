using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部面评 请求体
/// <para>导入来自其他系统的面评信息，创建为外部面评。</para>
/// <para>接口ID：6992822583076356099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview_assessment%2fcreate</para>
/// </summary>
public record PostHireV1ExternalInterviewAssessmentsBodyDto
{
    /// <summary>
    /// <para>外部系统面评主键（仅用于幂等）</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonProperty("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>面试官姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：shaojiale</para>
    /// </summary>
    [JsonProperty("username")]
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
    [JsonProperty("conclusion")]
    public int? Conclusion { get; set; }

    /// <summary>
    /// <para>评价维度列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("assessment_dimension_list")]
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
        [JsonProperty("score")]
        public int? Score { get; set; }

        /// <summary>
        /// <para>单选选项（当题目类型为「单选题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：opt</para>
        /// </summary>
        [JsonProperty("option")]
        public string? Option { get; set; }

        /// <summary>
        /// <para>多选选项（当题目类型为「多选题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989181065243969836</para>
        /// </summary>
        [JsonProperty("options")]
        public string[]? Options { get; set; }

        /// <summary>
        /// <para>描述内容（当题目类型为「描述题」时使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：content</para>
        /// </summary>
        [JsonProperty("content")]
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
        [JsonProperty("assessment_type")]
        public int? AssessmentType { get; set; }

        /// <summary>
        /// <para>题目标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>题目描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：desc</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// <para>综合记录</para>
    /// <para>必填：否</para>
    /// <para>示例值：helloworld</para>
    /// </summary>
    [JsonProperty("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>外部面试 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6986199832494934316</para>
    /// </summary>
    [JsonProperty("external_interview_id")]
    public string ExternalInterviewId { get; set; } = string.Empty;
}
