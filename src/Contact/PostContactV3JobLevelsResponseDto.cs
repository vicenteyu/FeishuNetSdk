using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建职级 响应体
/// <para>该接口可以创建职级。</para>
/// <para>接口ID：7194273512282423300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_level%2fcreate</para>
/// </summary>
public record PostContactV3JobLevelsResponseDto
{
    /// <summary>
    /// <para>职级信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("job_level")]
    public PostContactV3JobLevelsResponseDtoJobLevel? JobLevel { get; set; }

    /// <summary>
    /// <para>职级信息</para>
    /// </summary>
    public record PostContactV3JobLevelsResponseDtoJobLevel
    {
        /// <summary>
        /// <para>职级名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级专家</para>
        /// <para>最大长度：255</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>职级描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：公司内部中高级职称，有一定专业技术能力的人员</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>职级的排序，可填入自然数100-100000的数值，系统按照数值大小从小到大排序。不填写该字段时，默认新增排序在当前职级列表中最后位（最大值）</para>
        /// <para>必填：否</para>
        /// <para>示例值：200</para>
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>职级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonProperty("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>多语言名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonProperty("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：否</para>
            /// <para>示例值：多语言内容</para>
            /// </summary>
            [JsonProperty("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>多语言描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("i18n_description")]
        public I18nContent[]? I18nDescriptions { get; set; }
    }
}
