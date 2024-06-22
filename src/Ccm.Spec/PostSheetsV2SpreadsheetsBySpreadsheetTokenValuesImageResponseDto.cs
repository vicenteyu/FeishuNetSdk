namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 写入图片 响应体
/// <para>向电子表格某个工作表的单个指定单元格写入图片，支持传入图片的二进制流，支持多种图片格式。</para>
/// <para>接口ID：6907568073252585474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-images</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNxYjL1QTM24SN0EjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageResponseDto
{
    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>写入图片的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updatedRange")]
    public string? UpdatedRange { get; set; }

    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }
}
