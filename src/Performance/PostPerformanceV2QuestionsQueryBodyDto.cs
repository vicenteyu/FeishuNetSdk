// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2QuestionsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取标签填写题配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取标签填写题配置 请求体
/// <para>获取标签填写题配置信息，包括标签填写题名称、标签列表等</para>
/// <para>接口ID：7351374599659814916</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/question/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fquestion%2fquery</para>
/// </summary>
public record PostPerformanceV2QuestionsQueryBodyDto
{
    /// <summary>
    /// <para>标签填写题 ID 列表，获取指定标签填写题的配置数据。如果不传则返回所有</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("tag_based_question_ids")]
    public string[]? TagBasedQuestionIds { get; set; }
}
