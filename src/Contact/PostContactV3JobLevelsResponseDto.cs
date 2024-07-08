// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3JobLevelsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建职级 响应体
/// <para>调用该接口创建一个职级。职级是用户属性之一，用于标识用户的职位级别，例如 P1、P2、P3、P4。</para>
/// <para>接口ID：7194273512282423300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_level%2fcreate</para>
/// </summary>
public record PostContactV3JobLevelsResponseDto
{
    /// <summary>
    /// <para>职级信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_level")]
    public PostContactV3JobLevelsResponseDtoJobLevel? JobLevel { get; set; }

    /// <summary>
    /// <para>职级信息。</para>
    /// </summary>
    public record PostContactV3JobLevelsResponseDtoJobLevel
    {
        /// <summary>
        /// <para>职级名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级专家</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>职级描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：公司内部中高级职称，有一定专业技术能力的人员</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>职级排序，数值越小，排序越靠前。</para>
        /// <para>必填：否</para>
        /// <para>示例值：200</para>
        /// <para>最大值：100000</para>
        /// <para>最小值：100</para>
        /// </summary>
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// <para>是否启用职级。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：启用</para>
        /// <para>- false：不启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>职级 ID。后续可通过该 ID 删除、更新、查询职级。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>多语言名称。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言名称。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本。</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言版本对应的名称。</para>
            /// <para>必填：否</para>
            /// <para>示例值：多语言内容</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>多语言描述。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18nContent[]? I18nDescriptions { get; set; }
    }
}
