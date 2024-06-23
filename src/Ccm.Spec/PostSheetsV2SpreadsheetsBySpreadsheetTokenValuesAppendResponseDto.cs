// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>追加数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 追加数据 响应体
/// <para>在电子表格工作表的指定范围中，在空白位置中追加数据。例如，若指定范围参数 `range` 为 `6e5ed3!A1:B2`，该接口将会依次寻找 A1、A2、A3...单元格，在找到的第一个空白位置中写入数据。</para>
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto
{
    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>追加数据的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tableRange")]
    public string? TableRange { get; set; }

    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>追加数据的范围、更新的行列总数等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updates")]
    public UpdatesSuffix? Updates { get; set; }

    /// <summary></summary>
    public record UpdatesSuffix
    {
        /// <summary>
        /// <para>电子表格的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>追加数据的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>更新的行总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>更新的列总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>更新的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }

        /// <summary>
        /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }
    }
}
