using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 读取多个范围 响应体
/// <para>该接口用于根据 spreadsheetToken 和 ranges 读取表格多个范围的值，返回数据限制为10M。</para>
/// <para>接口ID：6907569743420325890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/reading-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTMzUjL5EzM14SOxMTN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto
{
    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>spreadsheet 的 token，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>读取的单元格总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("totalCells")]
    public int? TotalCells { get; set; }

    /// <summary>
    /// <para>值与范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("valueRanges")]
    public ValueRange[]? ValueRanges { get; set; }

    public record ValueRange
    {
        /// <summary>
        /// <para>插入维度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("majorDimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>返回数据的范围，为空时表示查询范围没有数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>sheet 的版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>查询得到的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("values")]
        public object[][]? Values { get; set; }
    }
}
