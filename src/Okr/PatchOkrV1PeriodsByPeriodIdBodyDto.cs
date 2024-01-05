namespace FeishuNetSdk.Okr;
/// <summary>
/// 修改 OKR 周期状态 请求体
/// <para>修改某个 OKR 周期的状态为「正常」、「失效」或「隐藏」，对租户所有人生效，请谨慎操作</para>
/// <para>接口ID：7177567881395732508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2fpatch</para>
/// </summary>
public record PatchOkrV1PeriodsByPeriodIdBodyDto
{
    /// <summary>
    /// <para>周期显示状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：正常状态</item>
    /// <item>2：标记失效</item>
    /// <item>3：隐藏周期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}
