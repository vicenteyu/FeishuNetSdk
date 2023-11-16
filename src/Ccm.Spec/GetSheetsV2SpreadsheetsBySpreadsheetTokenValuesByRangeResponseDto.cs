namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 读取单个范围 响应体
/// <para>该接口用于根据 spreadsheetToken 和 range 读取表格单个范围的值，返回数据限制为10M。</para>
/// <para>接口ID：6907569742384529410</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/reading-a-single-range</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugTMzUjL4EzM14COxMTN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesByRangeResponseDto
{
    /// <summary>
    /// <para>sheet 的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>spreadsheet 的 token，详见电子表格[概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>值与范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("valueRange")]
    public string? ValueRange { get; set; }

    /// <summary></summary>
    public record ValueRangeSuffix
    {
        /// <summary>
        /// <para>插入维度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>返回数据的范围，为空时表示查询范围没有数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>sheet 的版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>查询得到的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][]? Values { get; set; }
    }
}
