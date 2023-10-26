using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除行列 请求体
/// <para>该接口用于根据 spreadsheetToken 和维度信息删除行/列 。单次删除最大5000行/列。</para>
/// <para>接口ID：6907569524100382721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/-delete-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucjMzUjL3IzM14yNyMTN</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要删除行列的维度信息，将删除[startIndex,endIndex]区间的行或列</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    /// <summary></summary>
    public record DimensionSuffix
    {
        /// <summary>
        /// <para>sheetId</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("sheetId")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// <para>可选 ROWS、COLUMNS</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("majorDimension")]
        public string MajorDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>开始的位置，从1开始</para>
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
}
