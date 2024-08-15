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
/// <para>本接口支持修改 Offer 申请表的自定义字段，Offer 申请表的定义可参考「飞书招聘」-「设置」-「Offer 设置」-「Offer 申请表设置」中的内容。</para>
/// <para>## 注意事项</para>
/// <para>- Offer 申请表通过版本 (schema_id) 进行变更管理，自定义字段每次修改，全量申请表的 schema_id 会同步更新。</para>
/// <para>- 本接口不支持修改自定义字段类型。</para>
/// <para>- 本接口不支持修改字段类型为「公式」类型的字段值。</para>
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
        /// <para>字段中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：就职状态</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>字段英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Employment status</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }
    }

    /// <summary>
    /// <para>自定义字段配置信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("config")]
    public OfferCustomFieldConfig? Config { get; set; }

    /// <summary>
    /// <para>自定义字段配置信息</para>
    /// </summary>
    public record OfferCustomFieldConfig
    {
        /// <summary>
        /// <para>选项列表，仅字段类型为「单选」、「多选」时需传配置选项信息。字段类型可通过接口[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)获取</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("options")]
        public OfferCustomFieldConfigOption[]? Options { get; set; }

        /// <summary>
        /// <para>选项列表，仅字段类型为「单选」、「多选」时需传配置选项信息。字段类型可通过接口[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)获取</para>
        /// </summary>
        public record OfferCustomFieldConfigOption
        {
            /// <summary>
            /// <para>选项名称，zh_cn和en_us必填其一</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n Name { get; set; } = new();

            /// <summary>
            /// <para>选项名称，zh_cn和en_us必填其一</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>选项中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：无业</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>选项英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Unemployed</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
