namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单个工作城市信息 响应体
/// <para>此接口可用于获取单个工作城市信息。</para>
/// <para>接口ID：7256700963175022596</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fwork_city%2fget</para>
/// </summary>
public record GetContactV3WorkCitiesByWorkCityIdResponseDto
{
    /// <summary>
    /// <para>工作城市信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_city")]
    public GetContactV3WorkCitiesByWorkCityIdResponseDtoWorkCity? WorkCity { get; set; }

    /// <summary>
    /// <para>工作城市信息</para>
    /// </summary>
    public record GetContactV3WorkCitiesByWorkCityIdResponseDtoWorkCity
    {
        /// <summary>
        /// <para>工作城市ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：0dd1ec95f021</para>
        /// </summary>
        [JsonPropertyName("work_city_id")]
        public string? WorkCityId { get; set; }

        /// <summary>
        /// <para>工作城市名称。1-100字符，支持中、英文及符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多语言工作城市</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
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
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>多语言内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京</para>
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
}
