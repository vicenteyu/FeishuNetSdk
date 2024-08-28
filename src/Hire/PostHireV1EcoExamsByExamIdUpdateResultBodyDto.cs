// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoExamsByExamIdUpdateResultBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回传笔试结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传笔试结果 请求体
/// <para>飞书招聘的笔试服务商，可通过该接口回传候选人的笔试结果。回传笔试结果后，候选人在飞书招聘内的笔试状态将变为「已作答」。</para>
/// <para>接口ID：7195815979079467009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2fupdate_result</para>
/// </summary>
public record PostHireV1EcoExamsByExamIdUpdateResultBodyDto
{
    /// <summary>
    /// <para>笔试结果。表示该场笔试考生的笔试成绩，推荐传 "0"-"100" 的数字（字符串格式），如 "60"、"90" 等</para>
    /// <para>必填：是</para>
    /// <para>示例值：60.5</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = string.Empty;

    /// <summary>
    /// <para>笔试结果时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1658676234053</para>
    /// </summary>
    [JsonPropertyName("result_time")]
    public string? ResultTime { get; set; }

    /// <summary>
    /// <para>报告列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("report_list")]
    public EcoExamResultReport[]? ReportLists { get; set; }

    /// <summary>
    /// <para>报告列表</para>
    /// </summary>
    public record EcoExamResultReport
    {
        /// <summary>
        /// <para>报告名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三的笔试结果.pdf</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>报告链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxxx/xxxxxx/xxxx.pdf</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// <para>作答完成时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1658676234053</para>
        /// </summary>
        [JsonPropertyName("answer_time")]
        public string? AnswerTime { get; set; }
    }

    /// <summary>
    /// <para>详细评价结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("detail_list")]
    public EcoExamResultDetail[]? DetailLists { get; set; }

    /// <summary>
    /// <para>详细评价结果</para>
    /// </summary>
    public record EcoExamResultDetail
    {
        /// <summary>
        /// <para>评价项 ID，由调用方自定义</para>
        /// <para>必填：否</para>
        /// <para>示例值：pj001</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>评价项名称，由调用方自定义。</para>
        /// <para>单次调用支持传入多个相同的评价项名称，结果将在「飞书招聘」-「候选人详情」-「笔试卡片」中并列展示</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本功</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>评价结果，由调用方自定义</para>
        /// <para>必填：是</para>
        /// <para>示例值：优秀</para>
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = string.Empty;
    }
}
