// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向多个范围写入数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 向多个范围写入数据 响应体
/// <para>向电子表格某个工作表的多个指定范围中写入数据。若指定范围已内有数据，将被新写入的数据覆盖。</para>
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto
{
    /// <summary>
    /// <para>所有写入数据的范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("responses")]
    public Response[]? Responses { get; set; }

    /// <summary></summary>
    public record Response
    {
        /// <summary>
        /// <para>电子表格的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("spreadsheetToken")]
        public string? SpreadsheetToken { get; set; }

        /// <summary>
        /// <para>写入的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRange")]
        public string? UpdatedRange { get; set; }

        /// <summary>
        /// <para>写入的行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedRows")]
        public int? UpdatedRows { get; set; }

        /// <summary>
        /// <para>写入的列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedColumns")]
        public int? UpdatedColumns { get; set; }

        /// <summary>
        /// <para>写入的单元格总数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updatedCells")]
        public int? UpdatedCells { get; set; }
    }

    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }
}
