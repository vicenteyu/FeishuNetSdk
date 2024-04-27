namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新待入职信息（推荐） 响应体
/// <para>更新待入职对象指定字段的值</para>
/// <para>接口ID：7357756972752715778</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fpatch</para>
/// </summary>
public record PatchCorehrV2PreHiresByPreHireIdResponseDto
{
    /// <summary>
    /// <para>待入职ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7345005664477775407</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string? PreHireId { get; set; }
}
