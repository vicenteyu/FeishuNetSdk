// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向多个范围写入数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 向多个范围写入数据 请求体
/// <para>向电子表格某个工作表的多个指定范围中写入数据。若指定范围已内有数据，将被新写入的数据覆盖。</para>
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto
{
    /// <summary>
    /// <para>指定写入的数据值与范围，支持传入多个 `range` 和 `values` 参数。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("valueRanges")]
    public ValueRange[] ValueRanges { get; set; } = Array.Empty<ValueRange>();

    /// <summary></summary>
    public record ValueRange
    {
        /// <summary>
        /// <para>写入数据的范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取。</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
        /// <para>**注意**：`range` 所指定的范围需要大于等于写入的数据所占用的范围。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>写入的数据。如要写入公式、超链接、email、@人等，可参考[电子表格支持写入的数据类型](https://open.feishu.cn/document/ukTMukTMukTM/ugjN1UjL4YTN14CO2UTN)。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][] Values { get; set; } = Array.Empty<object[]>();
    }
}
