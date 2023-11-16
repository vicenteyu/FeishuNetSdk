namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 写入图片 响应体
/// <para>该接口用于根据 spreadsheetToken 和 range 向单个格子写入图片。</para>
/// <para>接口ID：6907568073252585474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-images</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNxYjL1QTM24SN0EjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>spreadsheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>写入图片的range</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updateRange")]
    public string? UpdateRange { get; set; }
}
