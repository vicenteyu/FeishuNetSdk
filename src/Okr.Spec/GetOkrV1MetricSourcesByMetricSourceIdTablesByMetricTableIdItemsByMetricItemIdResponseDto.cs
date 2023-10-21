using Newtonsoft.Json;
namespace FeishuNetSdk.Okr.Spec;
/// <summary>
/// 获取指标项详情 响应体
/// <para>获取某项指标的具体内容（仅限 OKR 企业版使用）。</para>
/// <para>接口ID：7153135267980279812</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/metric_source-table-item/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fmetric_source-table-item%2fget</para>
/// </summary>
public record GetOkrV1MetricSourcesByMetricSourceIdTablesByMetricTableIdItemsByMetricItemIdResponseDto
{
    /// <summary>
    /// <para>指标表id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_item_id")]
    public string? MetricItemId { get; set; }

    /// <summary>
    /// <para>指标承接人员id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>指标的okr周期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("period_id")]
    public string? PeriodId { get; set; }

    /// <summary>
    /// <para>指标单位</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_unit")]
    public MetricUnitSuffix? MetricUnit { get; set; }

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

    /// <summary>
    /// <para>指标起始值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_initial_value")]
    public float? MetricInitialValue { get; set; }

    /// <summary>
    /// <para>指标目标值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_target_value")]
    public float? MetricTargetValue { get; set; }

    /// <summary>
    /// <para>指标进度值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_current_value")]
    public float? MetricCurrentValue { get; set; }

    /// <summary>
    /// <para>指标支撑的上级人员id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("supported_user_id")]
    public string? SupportedUserId { get; set; }

    /// <summary>
    /// <para>指标关联的kr</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("kr_id")]
    public string? KrId { get; set; }

    /// <summary>
    /// <para>更新时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("updated_at")]
    public string? UpdatedAt { get; set; }

    /// <summary>
    /// <para>更新人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("updated_by")]
    public string? UpdatedBy { get; set; }
}
