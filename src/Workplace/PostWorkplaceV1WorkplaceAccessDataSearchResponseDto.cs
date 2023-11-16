namespace FeishuNetSdk.Workplace;
/// <summary>
/// 获取工作台访问数据 响应体
/// <para>获取工作台访问数据（包含默认工作台与定制工作台）</para>
/// <para>接口ID：7244463472595714050</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/workplace-v1/workplace_access_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fworkplace_access_data%2fsearch</para>
/// </summary>
public record PostWorkplaceV1WorkplaceAccessDataSearchResponseDto
{
    /// <summary>
    /// <para>工作台访问数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkplaceAccessData[]? Items { get; set; }

    /// <summary>
    /// <para>工作台访问数据</para>
    /// </summary>
    public record WorkplaceAccessData
    {
        /// <summary>
        /// <para>时间,精确到天,格式yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-03-12</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>全部工作台的访问数据。包含默认工作台和定制工作台。由于历史原因，部分情况下这这两个数据的和加起来不等于全部工作台的访问数据。如有疑问，可联系飞书技术支持。</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("all_workplace")]
        public AccessData? AllWorkplace { get; set; }

        /// <summary>
        /// <para>全部工作台的访问数据。包含默认工作台和定制工作台。由于历史原因，部分情况下这这两个数据的和加起来不等于全部工作台的访问数据。如有疑问，可联系飞书技术支持。</para>
        /// </summary>
        public record AccessData
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
        /// <para>默认工作台的访问数据</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("default_workplace")]
        public AccessData? DefaultWorkplace { get; set; }
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
