// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3JobFamiliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取租户序列列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取租户序列列表 响应体
/// <para>调用该接口获取当前租户下的序列信息，包含序列的名称、描述、启用状态以及 ID 等。</para>
/// <para>接口ID：7194273514093395972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2flist</para>
/// </summary>
public record GetContactV3JobFamiliesResponseDto
{
    /// <summary>
    /// <para>序列信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobFamily[]? Items { get; set; }

    /// <summary>
    /// <para>序列信息。</para>
    /// </summary>
    public record JobFamily
    {
        /// <summary>
        /// <para>序列名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：产品</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>序列描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：负责产品策略制定的相关工作</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>上级序列 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlpzjq</para>
        /// </summary>
        [JsonPropertyName("parent_job_family_id")]
        public string? ParentJobFamilyId { get; set; }

        /// <summary>
        /// <para>是否启用序列。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：启用</para>
        /// <para>- false：禁用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>多语言序列名称。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言序列名称。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本。</para>
            /// <para>**可能值有**：</para>
            /// <para>- zh_cn：中文</para>
            /// <para>- en_us：英语</para>
            /// <para>- ja_jp：日语</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言版本对应的值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：多语言内容</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>多语言序列描述。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18nContent[]? I18nDescriptions { get; set; }

        /// <summary>
        /// <para>序列 ID。后续可通过该 ID 更新、查询、删除序列。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlpkzy</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
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
