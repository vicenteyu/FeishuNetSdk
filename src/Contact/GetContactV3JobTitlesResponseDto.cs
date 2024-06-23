// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3JobTitlesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取租户职务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取租户职务列表 响应体
/// <para>此接口可用于获取租户下职务列表信息。</para>
/// <para>接口ID：7256700963175006212</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_title%2flist</para>
/// </summary>
public record GetContactV3JobTitlesResponseDto
{
    /// <summary>
    /// <para>职务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobTitle[]? Items { get; set; }

    /// <summary>
    /// <para>职务列表</para>
    /// </summary>
    public record JobTitle
    {
        /// <summary>
        /// <para>职务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：b5565c46b749</para>
        /// </summary>
        [JsonPropertyName("job_title_id")]
        public string? JobTitleId { get; set; }

        /// <summary>
        /// <para>职务名称。1-100字符，支持中、英文及符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言职务名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言职务名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>多语言内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：专家</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true表示启用,false表示未启用</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1r5QdASJi1sp5aJn</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
