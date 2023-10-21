using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入数据 响应体
/// <para>该接口用于根据 spreadsheetToken 和 range 向范围之前增加相应数据的行和相应的数据，相当于数组的插入操作；单次写入不超过5000行，100列，每个格子不超过5万字符。</para>
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto
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
