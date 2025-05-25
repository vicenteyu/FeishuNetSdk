// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="GetMdmV3CountryRegionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分页批量查询国家/地区 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mdm;
/// <summary>
/// 分页批量查询国家/地区 请求体
/// <para>分页批量查询国家/地区。资源介绍请参考[概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/country_region/resource-definition)。</para>
/// <para>接口ID：7359131293821468674</para>
/// <para>文档地址：https://open.feishu.cn/document/mdm-v1/mdm-v3/country_region/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v3%2fcountry_region%2flist</para>
/// </summary>
public record GetMdmV3CountryRegionsBodyDto
{
    /// <summary>
    /// <para>过滤参数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public GetMdmV3CountryRegionsBodyDtoFilter? Filter { get; set; }

    /// <summary>
    /// <para>过滤参数</para>
    /// </summary>
    public record GetMdmV3CountryRegionsBodyDtoFilter
    {
        /// <summary>
        /// <para>逻辑关系</para>
        /// <para>同一层级的多个expression由logic参数决定使用“与/或”条件</para>
        /// <para>0=and，1=or</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("logic")]
        public string Logic { get; set; } = string.Empty;

        /// <summary>
        /// <para>过滤条件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("expressions")]
        public Expression[]? Expressions { get; set; }

        /// <summary>
        /// <para>过滤条件</para>
        /// </summary>
        public record Expression
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field")]
            public string Field { get; set; } = string.Empty;

            /// <summary>
            /// <para>运算符。</para>
            /// <para>0=等于，1=不等于，2=大于，3=大于等于，4=小于，5=小于等于，6=属于任意，7=不属于任意，8=匹配，9=前缀匹配，10=后缀匹配，11=为空，12=不为空</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("value")]
            public ExpressionValue Value { get; set; } = new();

            /// <summary>
            /// <para>字段值</para>
            /// </summary>
            public record ExpressionValue
            {
                /// <summary>
                /// <para>字符串值</para>
                /// <para>必填：否</para>
                /// <para>示例值：安道尔</para>
                /// </summary>
                [JsonPropertyName("string_value")]
                public string? StringValue { get; set; }

                /// <summary>
                /// <para>布尔值</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("bool_value")]
                public bool? BoolValue { get; set; }

                /// <summary>
                /// <para>整型值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("int_value")]
                public string? IntValue { get; set; }

                /// <summary>
                /// <para>字符串列表值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("string_list_value")]
                public string[]? StringListValue { get; set; }

                /// <summary>
                /// <para>整型列表值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("int_list_value")]
                public string[]? IntListValue { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>此参数可忽略</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("common")]
    public object? Common { get; set; }
}
