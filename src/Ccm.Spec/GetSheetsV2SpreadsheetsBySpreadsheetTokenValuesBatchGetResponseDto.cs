// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>读取多个范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 读取多个范围 响应体
/// <para>读取电子表格中多个指定范围的数据。</para>
/// <para>接口ID：6907569743420325890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/reading-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTMzUjL5EzM14SOxMTN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto
{
    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>读取的单元格总数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("totalCells")]
    public int? TotalCells { get; set; }

    /// <summary>
    /// <para>读取的值与范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("valueRanges")]
    public ValueRange[]? ValueRanges { get; set; }

    /// <summary></summary>
    public record ValueRange
    {
        /// <summary>
        /// <para>返回的 values 数组中数据的呈现维度。固定取值 ROWS，即数据为从左到右、从上到下的读取顺序。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("majorDimension")]
        public string? MajorDimension { get; set; }

        /// <summary>
        /// <para>读取的范围。为空时表示查询范围没有数据。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>指定范围中的数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][]? Values { get; set; }
    }
}
