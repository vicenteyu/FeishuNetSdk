namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 合并单元格 响应体
/// <para>合并电子表格工作表中的单元格。</para>
/// <para>接口ID：6907569742387707906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/merge-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNzUjL5QzM14SO0MTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsResponseDto
{
    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }
}
