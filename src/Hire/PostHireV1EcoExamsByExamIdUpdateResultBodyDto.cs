using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传笔试结果 请求体
/// <para>回传笔试结果</para>
/// <para>接口ID：7195815979079467009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2fupdate_result</para>
/// </summary>
public record PostHireV1EcoExamsByExamIdUpdateResultBodyDto
{
    /// <summary>
    /// <para>笔试结果，推荐传"0"-"100" 的数字(字符串格式)，如"60"， "90"， 该字段表示该场笔试考生考试的成绩</para>
    /// <para>必填：是</para>
    /// <para>示例值：60.5</para>
    /// </summary>
    [JsonProperty("result")]
    public string Result { get; set; } = string.Empty;

    /// <summary>
    /// <para>笔试结果时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1658676234053</para>
    /// </summary>
    [JsonProperty("result_time")]
    public string? ResultTime { get; set; }

    /// <summary>
    /// <para>报告列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("report_list")]
    public EcoExamResultReport[]? ReportLists { get; set; }

    /// <summary>
    /// <para>报告列表</para>
    /// </summary>
    public record EcoExamResultReport
    {
        /// <summary>
        /// <para>报告名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：阶段报告.pdf</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>报告链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxxx/xxxxxx/xxxx.pdf</para>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// <para>作答完成时间(毫秒时间戳)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1658676234053</para>
        /// </summary>
        [JsonProperty("answer_time")]
        public string? AnswerTime { get; set; }
    }

    /// <summary>
    /// <para>详细评价结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("detail_list")]
    public EcoExamResultDetail[]? DetailLists { get; set; }

    /// <summary>
    /// <para>详细评价结果</para>
    /// </summary>
    public record EcoExamResultDetail
    {
        /// <summary>
        /// <para>评价 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：pj001</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评价名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本功</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>评价结果</para>
        /// <para>必填：是</para>
        /// <para>示例值：优秀</para>
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; } = string.Empty;
    }
}
