// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-23
//
// Last Modified By : yxr
// Last Modified On : 2024-10-23
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdKnowledgesAskResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行数据知识问答 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 执行数据知识问答 响应体
/// <para>执行飞书 Aily 的数据知识问答，返回基于指定数据知识的问答结果</para>
/// <para>接口ID：7424752773160779780</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/ask</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-knowledge%2fask</para>
/// </summary>
public record PostAilyV1AppsByAppIdKnowledgesAskResponseDto
{
    /// <summary>
    /// <para>响应状态，枚举值</para>
    /// <para>必填：否</para>
    /// <para>示例值：processing</para>
    /// <para>可选值：<list type="bullet">
    /// <item>processing：当前知识问答正在处理中</item>
    /// <item>finished：当前知识问答处理完成</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>结束类型，枚举值</para>
    /// <para>必填：否</para>
    /// <para>示例值：qa</para>
    /// <para>可选值：<list type="bullet">
    /// <item>qa：执行数据知识问答</item>
    /// <item>faq：执行标准问答对</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("finish_type")]
    public string? FinishType { get; set; }

    /// <summary>
    /// <para>响应消息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message")]
    public AilyKnowledgeMessage? Message { get; set; }

    /// <summary>
    /// <para>响应消息</para>
    /// </summary>
    public record AilyKnowledgeMessage
    {
        /// <summary>
        /// <para>消息内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：推荐一部电影</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }

    /// <summary>
    /// <para>知识问答运行过程结构化数据，status=finished 且 finish_type=qa 时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_data")]
    public AilyKnowledgeAskProcessData? ProcessData { get; set; }

    /// <summary>
    /// <para>知识问答运行过程结构化数据，status=finished 且 finish_type=qa 时返回</para>
    /// </summary>
    public record AilyKnowledgeAskProcessData
    {
        /// <summary>
        /// <para>有数据分析时，根据数据生成的图表描述，按markdown语义描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("chart_dsls")]
        public string[]? ChartDsls { get; set; }

        /// <summary>
        /// <para>召回的知识视图切片的文本数据</para>
        /// <para>必填：否</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("chunks")]
        public string[]? Chunks { get; set; }

        /// <summary>
        /// <para>有数据分析时，查询到数据结果，每个元素为 json 序列化后的数据结果</para>
        /// <para>必填：否</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("sql_data")]
        public string[]? SqlData { get; set; }
    }

    /// <summary>
    /// <para>匹配标准问答对结果，status=finished 且 finish_type=faq时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("faq_result")]
    public AilyKnowledgeFaq? FaqResult { get; set; }

    /// <summary>
    /// <para>匹配标准问答对结果，status=finished 且 finish_type=faq时返回</para>
    /// </summary>
    public record AilyKnowledgeFaq
    {
        /// <summary>
        /// <para>匹配问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：问题</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// <para>匹配描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：答案</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("answer")]
        public string? Answer { get; set; }
    }

    /// <summary>
    /// <para>是否有结果，true 则 代表 message 中的内容是通过配置知识而生成的</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_answer")]
    public bool? HasAnswer { get; set; }
}
