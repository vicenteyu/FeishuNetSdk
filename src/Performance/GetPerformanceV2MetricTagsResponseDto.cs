// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="GetPerformanceV2MetricTagsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标标签列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标标签列表 响应体
/// <para>批量获取指标的标签信息，如标签名称、创建时间等信息。</para>
/// <para>接口ID：7397354450872991745</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_tag%2flist</para>
/// </summary>
public record GetPerformanceV2MetricTagsResponseDto
{
    /// <summary>
    /// <para>指标标签列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MetricTag[]? Items { get; set; }

    /// <summary>
    /// <para>指标标签列表</para>
    /// </summary>
    public record MetricTag
    {
        /// <summary>
        /// <para>标签 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7302271694582841364</para>
        /// <para>最大长度：999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tag_id")]
        public string? TagId { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tag_name")]
        public I18n? TagName { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>标签中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>标签英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>标签顺序</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：1000000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// <para>创建时间戳（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1678870702466</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间戳（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1605529625257</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
