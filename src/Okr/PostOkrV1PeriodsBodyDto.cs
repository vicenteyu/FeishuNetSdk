namespace FeishuNetSdk.Okr;
/// <summary>
/// 创建 OKR 周期 请求体
/// <para>根据周期规则创建一个 OKR 周期。</para>
/// <para>接口ID：7177567881395716124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2fcreate</para>
/// </summary>
public record PostOkrV1PeriodsBodyDto
{
    /// <summary>
    /// <para>周期规则 id</para>
    /// <para>必填：是</para>
    /// <para>示例值：6969864184272078374</para>
    /// </summary>
    [JsonPropertyName("period_rule_id")]
    public string PeriodRuleId { get; set; } = string.Empty;

    /// <summary>
    /// <para>周期起始年月</para>
    /// <para>必填：是</para>
    /// <para>示例值：2022-01</para>
    /// </summary>
    [JsonPropertyName("start_month")]
    public string StartMonth { get; set; } = string.Empty;
}
