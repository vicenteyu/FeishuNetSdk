using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新行列 请求体
/// <para>该接口用于根据 spreadsheetToken 和维度信息更新隐藏行列、单元格大小；单次操作不超过5000行或列。</para>
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
    [JsonProperty("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    public record DimensionSuffix
    {
        /// <summary>
        /// <para>sheetId</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("sheetId")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>默认 ROWS ，可选 ROWS、COLUMNS</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("majorDimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>开始的位置</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// <para>结束的位置</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }

    /// <summary>
    /// <para>需要更新行列的属性</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("dimensionProperties")]
    public DimensionProperty DimensionProperties { get; set; } = new();

    public record DimensionProperty
    {
        /// <summary>
        /// <para>true 为显示，false 为隐藏行列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// <para>行/列的大小</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("fixedSize")]
        public int? FixedSize { get; set; }
    }
}
