namespace FeishuNetSdk.Workplace;
/// <summary>
/// 获取定制工作台访问数据 响应体
/// <para>获取定制工作台访问数据</para>
/// <para>接口ID：7244463472595697666</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/workplace-v1/custom_workplace_access_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fcustom_workplace_access_data%2fsearch</para>
/// </summary>
public record PostWorkplaceV1CustomWorkplaceAccessDataSearchResponseDto
{
    /// <summary>
    /// <para>定制工作台访问数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CustomWorkplaceAccessData[]? Items { get; set; }

    /// <summary>
    /// <para>定制工作台访问数据</para>
    /// </summary>
    public record CustomWorkplaceAccessData
    {
        /// <summary>
        /// <para>定制工作台ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：tpl_645b003aaa40001435b2ddw</para>
        /// </summary>
        [JsonPropertyName("custom_workplace_id")]
        public string? CustomWorkplaceId { get; set; }

        /// <summary>
        /// <para>访问数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("access_data")]
        public CustomWorkplaceAccessDataAccessData? AccessData { get; set; }

        /// <summary>
        /// <para>访问数据</para>
        /// </summary>
        public record CustomWorkplaceAccessDataAccessData
        {
            /// <summary>
            /// <para>访问次数</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("pv")]
            public int? Pv { get; set; }

            /// <summary>
            /// <para>访问用户数(去重)</para>
            /// <para>必填：否</para>
            /// <para>示例值：30</para>
            /// </summary>
            [JsonPropertyName("uv")]
            public int? Uv { get; set; }
        }

        /// <summary>
        /// <para>时间,精确到天,格式yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-03-12</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>定制工作台多语言名字。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_workplace_name")]
        public I18nName[]? CustomWorkplaceNames { get; set; }

        /// <summary>
        /// <para>定制工作台多语言名字。</para>
        /// </summary>
        public record I18nName
        {
            /// <summary>
            /// <para>ISO 639-1的语言代码。比如zh表示中文。</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh</para>
            /// </summary>
            [JsonPropertyName("language")]
            public string? Language { get; set; }

            /// <summary>
            /// <para>名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：名字</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ddowkdkl9w2d</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
