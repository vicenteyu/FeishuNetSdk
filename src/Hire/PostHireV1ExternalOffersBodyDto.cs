// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ExternalOffersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部 Offer 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部 Offer 请求体
/// <para>创建外部 Offer，可用于导入来自其他系统的 Offer 信息。</para>
/// <para>接口ID：7407298680640946179</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_offer/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fcreate</para>
/// </summary>
public record PostHireV1ExternalOffersBodyDto
{
    /// <summary>
    /// <para>外部系统 Offer 主键（仅用于幂等）</para>
    /// <para>- 若不传此值，则不进行幂等校验</para>
    /// <para>- 若传此值，则用于幂等校验，同一`external_id` 24小时内仅可创建一次</para>
    /// <para>必填：否</para>
    /// <para>示例值：729557715718</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>外部投递 ID，可通过[查询外部投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_application/list)接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7395015673275697419</para>
    /// </summary>
    [JsonPropertyName("external_application_id")]
    public string ExternalApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>Offer 创建时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1721899352428</para>
    /// </summary>
    [JsonPropertyName("biz_create_time")]
    public string? BizCreateTime { get; set; }

    /// <summary>
    /// <para>Offer 负责人姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三</para>
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// <para>Offer 状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：已发送</para>
    /// </summary>
    [JsonPropertyName("offer_status")]
    public string? OfferStatus { get; set; }

    /// <summary>
    /// <para>Offer 详情附件 ID 列表，可通过[创建附件](https://open.feishu.cn/document/ukTMukTMukTM/uIDN1YjLyQTN24iM0UjN/create_attachment)</para>
    /// <para>接口返回</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("attachment_id_list")]
    public string[]? AttachmentIdList { get; set; }
}
