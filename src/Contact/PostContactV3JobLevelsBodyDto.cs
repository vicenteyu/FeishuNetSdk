// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3JobLevelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职级 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建职级 请求体
/// <para>调用该接口创建一个职级。职级是用户属性之一，用于标识用户的职位级别，例如 P1、P2、P3、P4。</para>
/// <para>## 使用限制</para>
/// <para>单租户内职级数量总数上限为 10,000，但需要注意，如果总数超过 4,000，则无法在[管理后台](https://feishu.cn/admin)打开职级列表。</para>
/// <para>接口ID：7194273512282423300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_level%2fcreate</para>
/// </summary>
public record PostContactV3JobLevelsBodyDto
{
    /// <summary>
    /// <para>职级名称。通用名称，如果未设置多语言名称，则默认展示该名称。</para>
    /// <para>必填：是</para>
    /// <para>示例值：高级专家</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>职级描述。字符长度上限 5,000。通用描述，如果未设置多语言描述，则默认展示该描述。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：公司内部中高级职称，有一定专业技术能力的人员</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>职级排序。数值越小，排序越靠前。</para>
    /// <para>**默认值**：空。如果不传入该值，则默认职级排在列表最后位（即 order 取值为当前职级列表内的最大值）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：200</para>
    /// <para>最大值：100000</para>
    /// <para>最小值：100</para>
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// <para>是否启用该职级。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：启用</para>
    /// <para>- false：不启用</para>
    /// <para>**说明**：只有启用了的职级可以设置为用户属性。</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("status")]
    public bool Status { get; set; }

    /// <summary>
    /// <para>多语言职级名称。</para>
    /// <para>**默认值**：空，表示不设置多语言名称。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_name")]
    public I18nContent[]? I18nNames { get; set; }

    /// <summary>
    /// <para>多语言职级名称。</para>
    /// <para>**默认值**：空，表示不设置多语言名称。</para>
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
        /// <para>语言版本对应的职级名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：多语言内容</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>多语言职级描述。</para>
    /// <para>**默认值**：空，表示不设置多语言描述。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_description")]
    public I18nContent[]? I18nDescriptions { get; set; }
}
