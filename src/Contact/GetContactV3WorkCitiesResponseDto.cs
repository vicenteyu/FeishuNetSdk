using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取租户工作城市列表 响应体
/// <para>此接口可用于获取租户下工作城市列表信息。</para>
/// <para>接口ID：7256700963175038980</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fwork_city%2flist</para>
/// </summary>
public record GetContactV3WorkCitiesResponseDto
{
    /// <summary>
    /// <para>工作城市列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public WorkCity[]? Items { get; set; }

    /// <summary>
    /// <para>工作城市列表</para>
    /// </summary>
    public record WorkCity
    {
        /// <summary>
        /// <para>工作城市ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：0dd1ec95f021</para>
        /// </summary>
        [JsonProperty("work_city_id")]
        public string? WorkCityId { get; set; }

        /// <summary>
        /// <para>工作城市名称。1-100字符，支持中、英文及符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言工作城市</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言工作城市</para>
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
            /// <para>示例值：北京</para>
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

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1r5QdASJi1sp5aJn</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
