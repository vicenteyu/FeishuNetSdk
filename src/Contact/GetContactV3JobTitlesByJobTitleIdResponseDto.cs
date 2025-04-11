// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3JobTitlesByJobTitleIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取单个职务信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单个职务信息 响应体
/// <para>调用该接口获取指定职务的信息，包括职务的 ID、名称、多语言名称以及启用状态。</para>
/// <para>接口ID：7256700963174989828</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/job_title/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_title%2fget</para>
/// </summary>
public record GetContactV3JobTitlesByJobTitleIdResponseDto
{
    /// <summary>
    /// <para>职务信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_title")]
    public GetContactV3JobTitlesByJobTitleIdResponseDtoJobTitle? JobTitle { get; set; }

    /// <summary>
    /// <para>职务信息。</para>
    /// </summary>
    public record GetContactV3JobTitlesByJobTitleIdResponseDtoJobTitle
    {
        /// <summary>
        /// <para>职务 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：b5565c46b749</para>
        /// </summary>
        [JsonPropertyName("job_title_id")]
        public string? JobTitleId { get; set; }

        /// <summary>
        /// <para>职务名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言职务名称。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言职务名称。</para>
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
            /// <para>示例值：专家</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>是否启用职务。</para>
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
