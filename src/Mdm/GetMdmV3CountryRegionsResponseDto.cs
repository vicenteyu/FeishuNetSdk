// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="GetMdmV3CountryRegionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分页批量查询国家/地区 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mdm;
/// <summary>
/// 分页批量查询国家/地区 响应体
/// <para>分页批量查询国家/地区。资源介绍请参考[概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/country_region/resource-definition)。</para>
/// <para>接口ID：7359131293821468674</para>
/// <para>文档地址：https://open.feishu.cn/document/mdm-v1/mdm-v3/country_region/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v3%2fcountry_region%2flist</para>
/// </summary>
public record GetMdmV3CountryRegionsResponseDto
{
    /// <summary>
    /// <para>国家/地区目录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data")]
    public CountryRegion[]? Datas { get; set; }

    /// <summary>
    /// <para>国家/地区目录列表</para>
    /// </summary>
    public record CountryRegion
    {
        /// <summary>
        /// <para>三位字母代码。与ISO国家代码的三位代码一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// </summary>
        [JsonPropertyName("alpha_3_code")]
        public string? Alpha3Code { get; set; }

        /// <summary>
        /// <para>两位字母代码。与ISO国家代码的二位代码一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：AD</para>
        /// </summary>
        [JsonPropertyName("alpha_2_code")]
        public string? Alpha2Code { get; set; }

        /// <summary>
        /// <para>数字代码。与ISO国家代码的Numeric代码一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("numeric_code")]
        public string? NumericCode { get; set; }

        /// <summary>
        /// <para>国家/地区名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nString? Name { get; set; }

        /// <summary>
        /// <para>国家/地区名称</para>
        /// </summary>
        public record I18nString
        {
            /// <summary>
            /// <para>入参languages中排序第一的语言对应的值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：安道尔</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>入参languages中所有语言对应的值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：{ "zh-CN":"安道尔" }</para>
            /// </summary>
            [JsonPropertyName("multilingual_value")]
            public object? MultilingualValue { get; set; }

            /// <summary>
            /// <para>value实际返回的值对应的语言，如"zh-CN"</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("return_language")]
            public string? ReturnLanguage { get; set; }
        }

        /// <summary>
        /// <para>主数据编码（系统生成的唯一永久代码，格式为“MDCT+8位数字”）</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDCT00000001</para>
        /// </summary>
        [JsonPropertyName("mdm_code")]
        public string? MdmCode { get; set; }

        /// <summary>
        /// <para>国家/地区全称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("full_name")]
        public I18nString? FullName { get; set; }

        /// <summary>
        /// <para>国际电话区号</para>
        /// <para>必填：否</para>
        /// <para>示例值：+376</para>
        /// </summary>
        [JsonPropertyName("global_code")]
        public string? GlobalCode { get; set; }

        /// <summary>
        /// <para>是否生效。0代表否，1代表是</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>所属大洲。可选值如下</para>
        /// <para>1-亚洲，2-欧洲，3-非洲，4-北美洲，5-南美洲，6-大洋洲，7-南极洲）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("continents")]
        public Enum? Continents { get; set; }

        /// <summary>
        /// <para>所属大洲。可选值如下</para>
        /// <para>1-亚洲，2-欧洲，3-非洲，4-北美洲，5-南美洲，6-大洋洲，7-南极洲）</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>入参languages中排序第一的语言对应的值。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;

            /// <summary>
            /// <para>入参languages中所有语言对应的值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh-CN":"安道尔"}</para>
            /// </summary>
            [JsonPropertyName("multilingual_name")]
            public object? MultilingualName { get; set; }
        }
    }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("total")]
    public string? Total { get; set; }

    /// <summary>
    /// <para>下一次分页参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：token</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
