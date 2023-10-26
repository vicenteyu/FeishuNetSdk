using Newtonsoft.Json;
namespace FeishuNetSdk.Workplace;
/// <summary>
/// 获取定制工作台小组件访问数据 响应体
/// <para>获取定制工作台小组件访问数据</para>
/// <para>接口ID：7244463472595681282</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/workplace-v1/workplace_block_access_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fworkplace_block_access_data%2fsearch</para>
/// </summary>
public record PostWorkplaceV1WorkplaceBlockAccessDataSearchResponseDto
{
    /// <summary>
    /// <para>工作台中block的访问数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public BlockAccessData[]? Items { get; set; }

    /// <summary>
    /// <para>工作台中block的访问数据</para>
    /// </summary>
    public record BlockAccessData
    {
        /// <summary>
        /// <para>时间,精确到天,格式yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-03-12</para>
        /// </summary>
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>小组件id（BlockID）。可前往 飞书管理后台 &gt; 工作台 &gt; 定制工作台，选择指定的工作台并进入工作台编辑器，点击某个小组件，即可查看页面右侧面板中该小组件名称下方的“BlockID”</para>
        /// <para>必填：否</para>
        /// <para>示例值：283438293839422334</para>
        /// </summary>
        [JsonProperty("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// <para>block访问数据信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("access_data")]
        public BlockAccessDataAccessData? AccessData { get; set; }

        /// <summary>
        /// <para>block访问数据信息。</para>
        /// </summary>
        public record BlockAccessDataAccessData
        {
            /// <summary>
            /// <para>访问次数</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonProperty("pv")]
            public int? Pv { get; set; }

            /// <summary>
            /// <para>访问用户数(去重)</para>
            /// <para>必填：否</para>
            /// <para>示例值：30</para>
            /// </summary>
            [JsonProperty("uv")]
            public int? Uv { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ddowkdkl9w2d</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
