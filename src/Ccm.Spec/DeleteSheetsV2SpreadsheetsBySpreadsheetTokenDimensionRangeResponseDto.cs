namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除行列 响应体
/// <para>该接口用于根据 spreadsheetToken 和维度信息删除行/列 。单次删除最大5000行/列。</para>
/// <para>接口ID：6907569524100382721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/-delete-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucjMzUjL3IzM14yNyMTN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto
{
    /// <summary>
    /// <para>删除的行/列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delCount")]
    public int? DelCount { get; set; }

    /// <summary>
    /// <para>插入维度</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("majorDimension")]
    public string? MajorDimension { get; set; }
}
