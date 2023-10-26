using Newtonsoft.Json;
namespace FeishuNetSdk.Okr.Spec;
/// <summary>
/// 获取指标表 响应体
/// <para>获取指定指标库下有哪些指标表（仅限 OKR 企业版使用）。</para>
/// <para>接口ID：7153135267980312580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/metric_source-table-item/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fmetric_source-table%2flist</para>
/// </summary>
public record GetOkrV1MetricSourcesByMetricSourceIdTablesResponseDto
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
    /// <para>指标表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public MetricTable[]? Items { get; set; }

    /// <summary></summary>
    public record MetricTable
    {
        /// <summary>
        /// <para>指标表 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_table_id")]
        public string? MetricTableId { get; set; }

        /// <summary>
        /// <para>指标表名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("metric_table_name")]
        public string? MetricTableName { get; set; }

        /// <summary>
        /// <para>okr周期</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("period_id")]
        public string? PeriodId { get; set; }
    }
}
