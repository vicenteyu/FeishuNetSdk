namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动行列 请求体
/// <para>该接口用于移动行或列。行或列被移动到目标位置后，原本在目标位置的行列会对应右移或下移。</para>
/// <para>接口ID：6969403095454416924</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/move_dimension</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fmove_dimension</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionBodyDto
{
    /// <summary>
    /// <para>移动源位置信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("source")]
    public Dimension? Source { get; set; }

    /// <summary>
    /// <para>移动源位置信息</para>
    /// </summary>
    public record Dimension
    {
        /// <summary>
        /// <para>移动的维度。可选值：</para>
        /// <para>- `ROWS`：行</para>
        /// <para>- `COLUMNS`：列</para>
        /// <para>必填：否</para>
        /// <para>示例值：ROWS</para>
        /// </summary>
        [JsonPropertyName("major_dimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>要移动的行或列的起始位置。从 0 开始计数。若 `startIndex` 为 3，则从第 4 行或列开始移动。包含第 4 行或列。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// <para>要移动的行或列结束的位置。从 0 开始计数。若 `endIndex` 为 7，则要移动的范围至第 8 行或列结束。不包含第 8 行或列。</para>
        /// <para>示例：当 `majorDimension`为 `ROWS`、 `startIndex` 为 3、`endIndex ` 为 7 时，则移动第 4、5、6、7 行，共 4 行。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }
    }

    /// <summary>
    /// <para>移动的目标位置行或者列</para>
    /// <para>必填：否</para>
    /// <para>示例值：4</para>
    /// </summary>
    [JsonPropertyName("destination_index")]
    public int? DestinationIndex { get; set; }
}
