namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除保护范围 响应体
/// <para>该接口用于根据保护范围ID删除保护范围，最多支持同时删除10个ID。</para>
/// <para>接口ID：6923123667871629340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/delete-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTM5YjL2ETO24iNxkjN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelResponseDto
{
    /// <summary>
    /// <para>成功删除的保护范围ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delProtectIds")]
    public string[]? DelProtectIds { get; set; }
}
