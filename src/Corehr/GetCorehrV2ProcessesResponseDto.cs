namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询流程实例列表 响应体
/// <para>查询流程实例列表。</para>
/// <para>接口ID：7296819819722571804</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2flist</para>
/// </summary>
public record GetCorehrV2ProcessesResponseDto
{
    /// <summary>
    /// <para>流程实例ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_ids")]
    public string[]? ProcessIds { get; set; }

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
    /// <para>示例值：7278949005675988535</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
