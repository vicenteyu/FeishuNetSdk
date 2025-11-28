// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>追加数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 追加数据 请求体
/// <para>在电子表格工作表的指定范围中，在空白位置中追加数据。例如，若指定范围参数 `range` 为 `6e5ed3!A1:B2`，该接口将会依次寻找 A1、A2、A3...单元格，在找到的第一个空白位置中写入数据。</para>
/// <para>使用限制：</para>
/// <para>- 单次写入范围不可超过 5,000 行、100 列。</para>
/// <para>- 每个单元格不超过 50,000 字符，由于服务端会增加控制字符，因此推荐每个单元格不超过 40,000 字符。</para>
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto
{
    /// <summary>
    /// <para>指定工作表中的范围和追加的数据。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("valueRange")]
    public ValueRangeSuffix ValueRange { get; set; } = new();

    /// <summary></summary>
    public record ValueRangeSuffix
    {
        /// <summary>
        /// <para>追加数据的范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>**注意**：`range` 所指定的范围需要大于等于追加的数据所占用的范围。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>追加的数据。如要写入公式、超链接、email、@人等，可参考[支持写入数据类型](https://open.feishu.cn/document/ukTMukTMukTM/ugjN1UjL4YTN14CO2UTN)。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][] Values { get; set; } = [];
    }
}
