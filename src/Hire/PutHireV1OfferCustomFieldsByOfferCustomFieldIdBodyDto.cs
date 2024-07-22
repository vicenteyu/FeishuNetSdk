// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PutHireV1OfferCustomFieldsByOfferCustomFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新 Offer 申请表自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新 Offer 申请表自定义字段 请求体
/// <para>- 本文档支持通过接口更新「飞书招聘」-「设置」-「Offer 申请表设置」中 Offer 申请表的自定义字段配置；</para>
/// <para>- 当前修改申请表信息（包括更新自定义字段）后，所有申请表的 schema_id 均会更新，即所有申请表均会新增一个版本，申请表的 schema_id 会在创建 offer、更新 offer 中使用；</para>
/// <para>- 「飞书招聘」中 Offer 申请表自定义字段创建后，不支持修改字段类型，本接口亦不支持更新字段类型；</para>
/// <para>- 当前字段类型为「公式」的，不支持通过接口更新。</para>
/// <para>接口ID：7109767413990866947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_custom_field%2fupdate</para>
/// </summary>
public record PutHireV1OfferCustomFieldsByOfferCustomFieldIdBodyDto
{
    /// <summary>
    /// <para>自定义字段名称，zh_cn和en_us必填其一</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n Name { get; set; } = new();

    /// <summary>
    /// <para>自定义字段名称，zh_cn和en_us必填其一</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>中文</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }
    }

    /// <summary>
    /// <para>自定义字段配置信息，仅字段类型为「单选」、「多选」时需传配置选项信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("config")]
    public OfferCustomFieldConfig? Config { get; set; }

    /// <summary>
    /// <para>自定义字段配置信息，仅字段类型为「单选」、「多选」时需传配置选项信息</para>
    /// </summary>
    public record OfferCustomFieldConfig
    {
        /// <summary>
        /// <para>选项信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public OfferCustomFieldConfigOption[]? Options { get; set; }

        /// <summary>
        /// <para>选项信息</para>
        /// </summary>
        public record OfferCustomFieldConfigOption
        {
            /// <summary>
            /// <para>选项名称，zh_cn和en_us必填其一</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>选项名称，zh_cn和en_us必填其一</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
