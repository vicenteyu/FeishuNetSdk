// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2IndicatorsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取评估项列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取评估项列表 响应体
/// <para>批量获取评估项信息，如评估项名称、评估项类型、评估项等级配置等信息。</para>
/// <para>接口ID：7351374599659798532</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2findicator%2fquery</para>
/// </summary>
public record PostPerformanceV2IndicatorsQueryResponseDto : IPageableResponse<PostPerformanceV2IndicatorsQueryResponseDto.Indicator>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Indicator[]? Items => Indicators;

    /// <summary>
    /// <para>评估项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("indicators")]
    public Indicator[]? Indicators { get; set; }

    /// <summary>
    /// <para>评估项列表</para>
    /// </summary>
    public record Indicator
    {
        /// <summary>
        /// <para>评估项 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7343513161666707459</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>评估项名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>评估项名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>评估项中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：完成度</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>评估项英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Completeness</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>评估项类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：plus</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>general_review_item：常规评估项</item>
        /// <item>review_item_based_on_key_metric：关键指标评估项</item>
        /// <item>okr_review_item：OKR 评估项</item>
        /// <item>plus：加分项</item>
        /// <item>minus：减分项</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>评估项等级列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("options")]
        public IndicatorOption[]? Options { get; set; }

        /// <summary>
        /// <para>评估项等级列表</para>
        /// </summary>
        public record IndicatorOption
        {
            /// <summary>
            /// <para>评估项等级 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7343513161666707459</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>评估项等级名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>评估项等级名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>评估项等级中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：等级 1</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>评估项等级英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Rank 1</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>评估项等级代号</para>
            /// <para>必填：否</para>
            /// <para>示例值：qwerty</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("lable")]
            public string? Lable { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
