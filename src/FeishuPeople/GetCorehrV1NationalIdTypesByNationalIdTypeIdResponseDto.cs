// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1NationalIdTypesByNationalIdTypeIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单个国家证件类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个国家证件类型 响应体
/// <para>根据 ID 查询单个国家证件类型。</para>
/// <para>接口ID：7017694651622178820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/national_id_type/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fnational_id_type%2fget</para>
/// </summary>
public record GetCorehrV1NationalIdTypesByNationalIdTypeIdResponseDto
{
    /// <summary>
    /// <para>国家证件类型信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("national_id_type")]
    public GetCorehrV1NationalIdTypesByNationalIdTypeIdResponseDtoNationalIdType? NationalIdType { get; set; }

    /// <summary>
    /// <para>国家证件类型信息</para>
    /// </summary>
    public record GetCorehrV1NationalIdTypesByNationalIdTypeIdResponseDtoNationalIdType
    {
        /// <summary>
        /// <para>证件类型 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6888198886960137735</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>国家 / 地区ID，可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取对应的国家/地区信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：6862995747139225096</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string CountryRegionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = [];

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>校验规则（正则表达式）</para>
        /// <para>必填：是</para>
        /// <para>示例值：^\d{9}$</para>
        /// </summary>
        [JsonPropertyName("validation_rule")]
        public string ValidationRule { get; set; } = string.Empty;

        /// <summary>
        /// <para>校验规则描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("validation_rule_description")]
        public I18n[]? ValidationRuleDescriptions { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：AUS-TFN</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>证件类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("identification_type")]
        public Enum IdentificationType { get; set; } = new();

        /// <summary>
        /// <para>证件类型</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>自定义字段（暂不支持）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段（暂不支持）</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }
}
