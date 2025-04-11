// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ExternalOffersBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询外部 Offer 列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询外部 Offer 列表 请求体
/// <para>可根据外部投递 ID 或外部 Offer ID 列表查询外部 Offer 信息。</para>
/// <para>接口ID：7407298680641060867</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fbatch_query</para>
/// </summary>
public record PostHireV1ExternalOffersBatchQueryBodyDto
{
    /// <summary>
    /// <para>外部 Offer ID 列表，当传此值时，仅以此值作为条件查询，其他查询条件不生效</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("external_offer_id_list")]
    public string[]? ExternalOfferIdList { get; set; }
}
