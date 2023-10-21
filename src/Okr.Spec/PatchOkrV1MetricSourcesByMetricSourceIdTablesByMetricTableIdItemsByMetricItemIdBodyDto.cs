using Newtonsoft.Json;
namespace FeishuNetSdk.Okr.Spec;
/// <summary>
/// 更新指标项 请求体
/// <para>- 该接口用于更新某项指标，接口仅限 OKR 企业版使用。</para>
/// <para>更新成功后 OKR 系统会给以下人员发送消息通知：</para>
/// <para>- 首次更新目标值的人员</para>
/// <para>    - 已经将指标添加为 KR、且本次目标值/起始值/支撑的上级有变更的人员，不包含仅更新了进度值的人员</para>
/// <para>接口ID：7153135267980263428</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/metric_source-table-item/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fmetric_source-table-item%2fpatch</para>
/// </summary>
public record PatchOkrV1MetricSourcesByMetricSourceIdTablesByMetricTableIdItemsByMetricItemIdBodyDto
{
    /// <summary>
    /// <para>指标起始值</para>
    /// <para>**示例值**：1.0</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_initial_value")]
    public float? MetricInitialValue { get; set; }

    /// <summary>
    /// <para>指标目标值</para>
    /// <para>**示例值**：3.0</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_target_value")]
    public float? MetricTargetValue { get; set; }

    /// <summary>
    /// <para>指标进度值</para>
    /// <para>**示例值**：2.0</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("metric_current_value")]
    public float? MetricCurrentValue { get; set; }

    /// <summary>
    /// <para>指标支撑的上级人员 id</para>
    /// <para>**示例值**："7041857032248410131"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("supported_user_id")]
    public string? SupportedUserId { get; set; }
}
