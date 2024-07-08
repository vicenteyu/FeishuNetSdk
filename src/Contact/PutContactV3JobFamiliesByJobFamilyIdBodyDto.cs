// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutContactV3JobFamiliesByJobFamilyIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新序列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新序列 请求体
/// <para>调用该接口更新指定序列的信息。</para>
/// <para>接口ID：7194273512282406916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2fupdate</para>
/// </summary>
public record PutContactV3JobFamiliesByJobFamilyIdBodyDto
{
    /// <summary>
    /// <para>序列名称，租户内唯一。取值支持中、英文及符号。</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：产品</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>序列描述，描述序列详情信息。字符长度上限为 5,000。</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：负责产品策略制定的相关工作</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>上级序列 ID。你可以调用[获取租户序列列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_family/list)接口，获取序列 ID。</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlpzjq</para>
    /// </summary>
    [JsonPropertyName("parent_job_family_id")]
    public string? ParentJobFamilyId { get; set; }

    /// <summary>
    /// <para>是否启用序列。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：启用</para>
    /// <para>- false：禁用</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>
    /// <para>多语言序列名称。</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_name")]
    public I18nContent[]? I18nNames { get; set; }

    /// <summary>
    /// <para>多语言序列名称。</para>
    /// <para>**默认值**：空，表示不更新</para>
    /// </summary>
    public record I18nContent
    {
        /// <summary>
        /// <para>语言版本。可选值有：</para>
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
    /// <para>**默认值**：空，表示不更新</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_description")]
    public I18nContent[]? I18nDescriptions { get; set; }
}
