// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="DeletePerformanceV2AdditionalInformationsBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除补充信息 响应体</summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量删除补充信息 响应体
/// <para>批量删除被评估人的补充信息。</para>
/// <para>接口ID：7371009404255600644</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_informations-batch/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_informations-batch%2fdelete</para>
/// </summary>
public record DeletePerformanceV2AdditionalInformationsBatchResponseDto
{
    /// <summary>
    /// <para>被删除的补充信息 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("additional_informations")]
    public string[]? AdditionalInformations { get; set; }
}
