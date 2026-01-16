namespace FeishuNetSdk.Approval.Shared;

/// <summary>
/// 审批实例控件值
/// </summary>
public record FormSuffixDto
{
    /// <summary>
    /// <para>控件 ID，也可以使用自定义 ID custom_id 的值</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// <para>控件类型</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>控件值，不同类型的值格式不一样</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}
