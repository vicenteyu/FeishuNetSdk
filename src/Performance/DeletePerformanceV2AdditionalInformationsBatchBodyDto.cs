// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="DeletePerformanceV2AdditionalInformationsBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除补充信息 请求体</summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量删除补充信息 请求体
/// <para>批量删除被评估人的补充信息。</para>
/// <para>接口ID：7371009404255600644</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_informations-batch/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_informations-batch%2fdelete</para>
/// </summary>
public record DeletePerformanceV2AdditionalInformationsBatchBodyDto
{
    /// <summary>
    /// <para>评估周期 ID，可通过[获取周期列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7348736302176534547</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补充信息 ID 列表，可通过[批量查询补充信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/query)接口获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("additional_informations")]
    public string[] AdditionalInformations { get; set; } = Array.Empty<string>();
}
