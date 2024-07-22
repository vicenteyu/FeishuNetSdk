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
/// <para>租户打开「通过 api 同步三方协议」开关并在校招流程特定阶段配置「三方协议」时，可以为 Offer 办公地点在中国大陆的校招投递创建三方协议，通过投递 ID 创建三方协议与对应状态。</para>
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
