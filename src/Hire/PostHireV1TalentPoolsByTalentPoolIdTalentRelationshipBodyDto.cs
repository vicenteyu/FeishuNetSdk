// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才加入人才库 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才加入人才库 请求体
/// <para>将人才加入人才库</para>
/// <para>接口ID：7218853190452445188</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/move_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fmove_talent</para>
/// </summary>
public record PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipBodyDto
{
    /// <summary>
    /// <para>人才 ID，可通过接口 [获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list) 获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>加入类型，加入后是否从其他库移出</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：否</item>
    /// <item>2：是</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("add_type")]
    public int AddType { get; set; }
}
