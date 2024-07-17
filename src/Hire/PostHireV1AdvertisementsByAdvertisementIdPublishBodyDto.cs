// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>职位发布至官网 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 职位发布至官网 请求体
/// <para>支持把职位发布至招聘官网、内推平台。</para>
/// <para>接口ID：7012986483075547137</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/publish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fadvertisement%2fpublish</para>
/// </summary>
public record PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto
{
    /// <summary>
    /// <para>职位渠道 ID，选择要发布的招聘官网，单次仅可发布 1 个渠道，1. 内推平台提供对应的 id = 3，2. 官网渠道的 ID 通过接口「获取官网列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956631</para>
    /// </summary>
    [JsonPropertyName("job_channel_id")]
    public string? JobChannelId { get; set; }
}
