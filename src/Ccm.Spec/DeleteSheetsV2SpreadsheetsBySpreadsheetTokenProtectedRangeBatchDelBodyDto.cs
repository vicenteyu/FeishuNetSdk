namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除保护范围 请求体
/// <para>该接口用于根据保护范围ID删除保护范围，最多支持同时删除10个ID。</para>
/// <para>接口ID：6923123667871629340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/delete-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTM5YjL2ETO24iNxkjN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelBodyDto
{
    /// <summary>
    /// <para>需要删除的保护范围ID，可以通过[获取表格元数据](https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN)接口获取</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("protectIds")]
    public string[] ProtectIds { get; set; } = Array.Empty<string>();
}
