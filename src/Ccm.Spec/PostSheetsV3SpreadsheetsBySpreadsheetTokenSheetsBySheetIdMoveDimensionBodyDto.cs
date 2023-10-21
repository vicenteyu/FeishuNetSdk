using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 移动行列 请求体
/// <para>该接口用于移动行列，行列被移动到目标位置后，原本在目标位置的行列会对应右移或下移。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=sheets&version=v3&resource=spreadsheet.sheet&method=move_dimension)</para>
/// <para>接口ID：6969403095454416924</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/move_dimension</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fmove_dimension</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionBodyDto
{
    /// <summary>
    /// <para>移动源位置参数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("source")]
    public Dimension? Source { get; set; }

    public record Dimension
    {
        /// <summary>
        /// <para>操作行还是列，取值：ROWS、COLUMNS</para>
        /// <para>**示例值**："ROWS"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("major_dimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>起始行或者列号</para>
        /// <para>**示例值**：0</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// <para>结束行或者列号</para>
        /// <para>**示例值**：1</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("end_index")]
        public int? EndIndex { get; set; }
    }

    /// <summary>
    /// <para>移动的目标位置行或者列号</para>
    /// <para>**示例值**：4</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("destination_index")]
    public int? DestinationIndex { get; set; }
}
