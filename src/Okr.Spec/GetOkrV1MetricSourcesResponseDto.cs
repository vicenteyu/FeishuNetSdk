using Newtonsoft.Json;
namespace FeishuNetSdk.Okr.Spec;
/// <summary>
/// 获取指标库 响应体
/// <para>获取租户下全部 OKR 指标库（仅限 OKR 企业版使用）。</para>
/// <para>接口ID：7153135267980328964</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/metric_source-table-item/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fmetric_source%2flist</para>
/// </summary>
public record GetOkrV1MetricSourcesResponseDto
{
    /// <summary>
    /// <para>符合条件的记录总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否有下一页</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>下一页页码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>指标库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public MetricSource[]? Items { get; set; }

    /// <summary></summary>
    public record MetricSource
    {
        /// <summary>
        /// <para>指标库 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_source_id")]
        public string? MetricSourceId { get; set; }

        /// <summary>
        /// <para>指标库名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_source_name")]
        public string? MetricSourceName { get; set; }

        /// <summary>
        /// <para>指标名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_name")]
        public string? MetricName { get; set; }

        /// <summary>
        /// <para>指标单位</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_unit")]
        public MetricUnitSuffix? MetricUnit { get; set; }

        /// <summary></summary>
        public record MetricUnitSuffix
        {
            /// <summary>
            /// <para>指标单位中文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>指标单位英文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }

            /// <summary>
            /// <para>指标单位日文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("ja_jp")]
            public string? JaJp { get; set; }
        }
    }
}
