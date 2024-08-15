// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TripartiteAgreementsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建三方协议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建三方协议 响应体
/// <para>在投递上创建三方协议。</para>
/// <para>## 前提条件</para>
/// <para>- 在「飞书招聘」-「设置」-「候选人流程管理」-「三方协议设置」中勾选了「通过 API 维护三方协议」。</para>
/// <para>- 该投递为校招投递。</para>
/// <para>- 该投递的 Offer 办公地点在中国大陆。</para>
/// <para>接口ID：7307160083569623043</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/tripartite_agreement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2fcreate</para>
/// </summary>
public record PostHireV1TripartiteAgreementsResponseDto
{
    /// <summary>
    /// <para>创建的三方协议的 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
