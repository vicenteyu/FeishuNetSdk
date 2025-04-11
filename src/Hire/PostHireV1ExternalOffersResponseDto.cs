// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ExternalOffersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部 Offer 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部 Offer 响应体
/// <para>创建外部 Offer，可用于导入来自其他系统的 Offer 信息。</para>
/// <para>接口ID：7407298680640946179</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fcreate</para>
/// </summary>
public record PostHireV1ExternalOffersResponseDto
{
    /// <summary>
    /// <para>外部 Offer</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_offer")]
    public PostHireV1ExternalOffersResponseDtoExternalOffer? ExternalOffer { get; set; }

    /// <summary>
    /// <para>外部 Offer</para>
    /// </summary>
    public record PostHireV1ExternalOffersResponseDtoExternalOffer
    {
        /// <summary>
        /// <para>外部 Offer ID（由飞书招聘系统生成）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>外部投递 ID</para>
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
        /// <para>Offer 详情附件列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attachment_list")]
        public ExternalCommonAttachment[]? AttachmentLists { get; set; }

        /// <summary>
        /// <para>Offer 详情附件列表</para>
        /// </summary>
        public record ExternalCommonAttachment
        {
            /// <summary>
            /// <para>附件 ID，详情可查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6987954043925432620</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附件名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：test_resume.pdf</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>附件大小（单位：字节）</para>
            /// <para>必填：否</para>
            /// <para>示例值：126371</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }
        }
    }
}
