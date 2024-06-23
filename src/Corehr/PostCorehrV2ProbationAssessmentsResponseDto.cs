// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2ProbationAssessmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增试用期考核信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 新增试用期考核信息 响应体
/// <para>新增员工试用期考核结果</para>
/// <para>接口ID：7254814386694586370</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation-assessment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation-assessment%2fcreate</para>
/// </summary>
public record PostCorehrV2ProbationAssessmentsResponseDto
{
    /// <summary>
    /// <para>创建的试用期考核记录 ID 列表，有序返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assessment_ids")]
    public string[]? AssessmentIds { get; set; }
}
