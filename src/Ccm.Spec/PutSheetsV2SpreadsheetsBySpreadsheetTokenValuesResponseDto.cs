// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向单个范围写入数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 向单个范围写入数据 响应体
/// <para>向电子表格某个工作表的单个指定范围中写入数据。若指定范围内已有数据，将被新写入的数据覆盖。</para>
/// <para>使用限制：- 单次写入数据不得超过 5000 行、100列。</para>
/// <para>- 每个单元格不超过 50,000 字符，由于服务端会增加控制字符，因此推荐每个单元格不超过 40,000 字符。</para>
/// <para>接口ID：6907569745298980866</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-a-single-range</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjMzUjLwIzM14CMyMTN</para>
/// </summary>
public record PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesResponseDto
{
    /// <summary>
    /// <para>电子表格的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>工作表的版本号。从 0 开始计数，更新一次版本号加一。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>写入数据的范围</para>
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
