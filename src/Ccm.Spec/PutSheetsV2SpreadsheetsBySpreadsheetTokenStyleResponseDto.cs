namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 设置单元格样式  响应体
/// <para>该接口用于根据 spreadsheetToken 、range 和样式信息更新单元格样式；单次写入不超过5000行，100列。建议在设置边框样式时，每次更新的单元格数量不要超过30000个。</para>
/// <para>接口ID：6907569523176783873</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjMzUjL5IzM14SOyMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>设置样式的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updatedRange")]
    public string? UpdatedRange { get; set; }

    /// <summary>
    /// <para>设置样式的行数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updatedRows")]
    public int? UpdatedRows { get; set; }

    /// <summary>
    /// <para>设置样式的列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updatedColumns")]
    public int? UpdatedColumns { get; set; }

    /// <summary>
    /// <para>设置样式的单元格总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updatedCells")]
    public int? UpdatedCells { get; set; }

    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }
}
