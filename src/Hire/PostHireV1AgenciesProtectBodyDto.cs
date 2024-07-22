// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1AgenciesProtectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置猎头保护期 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 设置猎头保护期 请求体
/// <para>设置猎头保护期。</para>
/// <para>接口ID：6965472560995041282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/agency/protect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect</para>
/// </summary>
public record PostHireV1AgenciesProtectBodyDto
{
    /// <summary>
    /// <para>人才ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6962051712422398239</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>供应商ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6898173495386147079</para>
    /// </summary>
    [JsonPropertyName("supplier_id")]
    public string SupplierId { get; set; } = string.Empty;

    /// <summary>
    /// <para>猎头顾问ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
    /// </summary>
    [JsonPropertyName("consultant_id")]
    public string ConsultantId { get; set; } = string.Empty;

    /// <summary>
    /// <para>保护期创建时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：1610695587000</para>
    /// </summary>
    [JsonPropertyName("protect_create_time")]
    public int ProtectCreateTime { get; set; }

    /// <summary>
    /// <para>保护期过期时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：1626333987000</para>
    /// </summary>
    [JsonPropertyName("protect_expire_time")]
    public int ProtectExpireTime { get; set; }

    /// <summary>
    /// <para>推荐语</para>
    /// <para>必填：否</para>
    /// <para>示例值：此候选人非常优秀，建议录用。</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>当前薪资</para>
    /// <para>必填：否</para>
    /// <para>示例值：15k * 13</para>
    /// </summary>
    [JsonPropertyName("current_salary")]
    public string? CurrentSalary { get; set; }

    /// <summary>
    /// <para>预期薪资</para>
    /// <para>必填：否</para>
    /// <para>示例值：18k * 16</para>
    /// </summary>
    [JsonPropertyName("expected_salary")]
    public string? ExpectedSalary { get; set; }
}
