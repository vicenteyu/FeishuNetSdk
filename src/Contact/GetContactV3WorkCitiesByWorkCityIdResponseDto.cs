// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3WorkCitiesByWorkCityIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取单个工作城市信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单个工作城市信息 响应体
/// <para>调用该接口获取指定工作城市的信息，包括工作城市的 ID、名称、多语言名称以及启用状态。</para>
/// <para>接口ID：7256700963175022596</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fwork_city%2fget</para>
/// </summary>
public record GetContactV3WorkCitiesByWorkCityIdResponseDto
{
    /// <summary>
    /// <para>工作城市信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_city")]
    public GetContactV3WorkCitiesByWorkCityIdResponseDtoWorkCity? WorkCity { get; set; }

    /// <summary>
    /// <para>工作城市信息。</para>
    /// </summary>
    public record GetContactV3WorkCitiesByWorkCityIdResponseDtoWorkCity
    {
        /// <summary>
        /// <para>工作城市 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0dd1ec95f021</para>
        /// </summary>
        [JsonPropertyName("work_city_id")]
        public string? WorkCityId { get; set; }

        /// <summary>
        /// <para>工作城市名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言工作城市名称。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言工作城市名称。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本。例如：</para>
            /// <para>- zh_cn：中文</para>
            /// <para>- en_us：英语</para>
            /// <para>- ja_jp：日语</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>多语言版本对应的值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>是否启用工作城市。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：启用</para>
        /// <para>- false：禁用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }
    }
}
