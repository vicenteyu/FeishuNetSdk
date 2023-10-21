using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入行列 请求体
/// <para>该接口用于根据 spreadsheetToken 和维度信息 插入空行/列。</para>
/// <para>如 startIndex=3， endIndex=7，则从第 4 行开始开始插入行列，一直到第 7 行，共插入 4 行；单次操作不超过5000行或列。</para>
/// <para>接口ID：6907569743420194818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/insert-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMzUjL0IzM14CNyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto
{
    /// <summary>
    /// <para>需要插入行列的维度信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("dimension")]
    public DimensionSuffix Dimension { get; set; } = new();

    public record DimensionSuffix
    {
        /// <summary>
        /// <para>sheet 的 Id</para>
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
    /// <para>BEFORE 或 AFTER，不填为不继承 style</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("inheritStyle")]
    public string? InheritStyle { get; set; }
}
