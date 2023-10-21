using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 追加数据 响应体
/// <para>该接口用于在已有数据的末尾追加写入给定的数据。该接口会从给定的range中的起始行列开始向下寻找（如range为"sheet1!A1:B2",将会依次寻找A1、A2、A3...），找到第一个空白位置后将数据写入到该区域。单次写入不得超过5000行，100列，每个格子不得超过5万字符。</para>
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>写入的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tableRange")]
    public string? TableRange { get; set; }

    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>插入数据的范围、行列数等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("updates")]
    public Update? Updates { get; set; }

    public record Update
    {
        /// <summary>
        /// <para>spreadsheet 的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>写入的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>写入的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>写入的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>写入的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updatedCells")]
        public int? UpdatedCells { get; set; }

        /// <summary>
        /// <para>sheet 的版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("revision")]
        public int? Revision { get; set; }
    }
}
