// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才加入人才库 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才加入人才库 响应体
/// <para>将人才加入人才库。</para>
/// <para>接口ID：7218853190452445188</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/move_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fmove_talent</para>
/// </summary>
public record PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipResponseDto
{
    /// <summary>
    /// <para>人才库 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("talent_pool_id")]
    public string? TalentPoolId { get; set; }

    /// <summary>
    /// <para>人才 ID，详情请查看接口：[获取人才详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }
}
