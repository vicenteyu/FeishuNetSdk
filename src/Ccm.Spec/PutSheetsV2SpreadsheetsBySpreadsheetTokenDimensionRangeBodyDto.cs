namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新行列 请求体
/// <para>该接口用于更新设置电子表格中行列的属性，包括是否隐藏行列和设置行高列宽。</para>
/// <para>接口ID：6907569742383562754</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/update-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYjMzUjL2IzM14iNyMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要更新行列的维度信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    /// <summary></summary>
    public record DimensionSuffix
    {
        /// <summary>
        /// <para>工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>更新的维度。可选值：</para>
        /// <para>- `ROWS`：行</para>
        /// <para>- `COLUMNS`：列</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string MajorDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>要更新的行或列的起始位置。从 0 开始计数。若 `startIndex` 为 3，则从第 4 行或列开始更新属性。包含第 4 行或列。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// <para>要更新的行或列结束的位置。从 0 开始计数。若 `endIndex` 为 7，则更新至第 8 行结束。不包含第 8 行。</para>
        /// <para>示例：当 `majorDimension`为 `ROWS`、 `startIndex` 为 3、`endIndex ` 为 7 时，则更新第 4、5、6、7 行的属性，共更新 4 行。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("endIndex")]
        public int EndIndex { get; set; }
    }

    /// <summary>
    /// <para>更新行或列的属性。至少写入以下参数之一</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dimensionProperties")]
    public DimensionProperty DimensionProperties { get; set; } = new();

    /// <summary></summary>
    public record DimensionProperty
    {
        /// <summary>
        /// <para>是否隐藏行或列。可选值：</para>
        /// <para>- true：显示行或列</para>
        /// <para>- false：隐藏行或列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// <para>行高或列宽。单位为像素。`fixedSize` 为 0 时，等价于隐藏行或列。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("fixedSize")]
        public int? FixedSize { get; set; }
    }
}
