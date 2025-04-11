// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="PostCorehrV1LeavesWorkCalendarBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作日历 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取工作日历 请求体
/// <para>获取工作日历信息，如名称，状态等</para>
/// <para>接口ID：7408403062694100995</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar</para>
/// </summary>
public record PostCorehrV1LeavesWorkCalendarBodyDto
{
    /// <summary>
    /// <para>工作日历ID列表，第一次传入时可以传入空数组，形如[]</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("wk_calendar_ids")]
    public string[] WkCalendarIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>工作日历ID大于</para>
    /// <para>必填：否</para>
    /// <para>示例值：7136914415957591596</para>
    /// </summary>
    [JsonPropertyName("wk_calendar_id_gt")]
    public string? WkCalendarIdGt { get; set; }

    /// <summary>
    /// <para>分页、排序等选项，注意需要填写limit参数，默认为0</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("wk_option")]
    public PostCorehrV1LeavesWorkCalendarBodyDtoWkOption? WkOption { get; set; }

    /// <summary>
    /// <para>分页、排序等选项，注意需要填写limit参数，默认为0</para>
    /// </summary>
    public record PostCorehrV1LeavesWorkCalendarBodyDtoWkOption
    {
        /// <summary>
        /// <para>是否返回符合条件的工作日历总数</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("count")]
        public bool? Count { get; set; }

        /// <summary>
        /// <para>分页查询的位移，从0开始</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>分页查询 单次查询数量</para>
        /// <para>必填：是</para>
        /// <para>示例值：20</para>
        /// <para>最大值：2000</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// <para>排序</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("sort_options")]
        public SortOption[]? SortOptions { get; set; }

        /// <summary>
        /// <para>排序</para>
        /// </summary>
        public record SortOption
        {
            /// <summary>
            /// <para>排序字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：wk_id</para>
            /// </summary>
            [JsonPropertyName("sort_field")]
            public string? SortField { get; set; }

            /// <summary>
            /// <para>排序顺序</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最大值：1</para>
            /// <para>最小值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：升序</item>
            /// <item>1：降序</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("sort_order")]
            public int? SortOrder { get; set; }

            /// <summary>
            /// <para>0=中文关键字;1=英文关键字;2=拼音</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：2</para>
            /// <para>最小值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：中文关键字</item>
            /// <item>1：英文关键字</item>
            /// <item>2：拼音</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("sort_i18n")]
            public int? SortI18n { get; set; }

            /// <summary>
            /// <para>按某个字段的层级深度排序</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("sort_by_strand_length")]
            public bool? SortByStrandLength { get; set; }

            /// <summary>
            /// <para>是否按照拼音排序</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("sort_by_pinyin")]
            public bool? SortByPinyin { get; set; }

            /// <summary>
            /// <para>是否按照枚举类型 value_order 排序</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("sort_by_enum_value_order")]
            public bool? SortByEnumValueOrder { get; set; }
        }
    }

    /// <summary>
    /// <para>是否只返回启用的工作日历，不填默认true</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：true</para>
    /// </summary>
    [JsonPropertyName("only_enable")]
    public bool? OnlyEnable { get; set; }
}
