using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单个职务信息 响应体
/// <para>该接口可以获取单个职务的信息。</para>
/// <para>接口ID：7256700963174989828</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_title%2fget</para>
/// </summary>
public record GetContactV3JobTitlesByJobTitleIdResponseDto
{
    /// <summary>
    /// <para>职务信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("job_title")]
    public GetContactV3JobTitlesByJobTitleIdResponseDtoJobTitle? JobTitle { get; set; }

    /// <summary>
    /// <para>职务信息</para>
    /// </summary>
    public record GetContactV3JobTitlesByJobTitleIdResponseDtoJobTitle
    {
        /// <summary>
        /// <para>职务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：b5565c46b749</para>
        /// </summary>
        [JsonProperty("job_title_id")]
        public string? JobTitleId { get; set; }

        /// <summary>
        /// <para>职务名称。1-100字符，支持中、英文及符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言职务名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("i18n_name")]
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
            [JsonProperty("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>多语言内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：专家</para>
            /// </summary>
            [JsonProperty("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true表示启用,false表示未启用</para>
        /// </summary>
        [JsonProperty("status")]
        public bool? Status { get; set; }
    }
}
