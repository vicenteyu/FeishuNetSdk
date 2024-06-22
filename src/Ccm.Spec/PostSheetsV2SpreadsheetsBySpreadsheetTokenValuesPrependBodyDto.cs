namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 插入数据 请求体
/// <para>在电子表格工作表的指定范围的起始位置上方增加若干行，并在该范围中填充数据。</para>
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto
{
    /// <summary>
    /// <para>指定工作表中的范围和在该范围中插入的数据。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("valueRange")]
    public ValueRangeSuffix ValueRange { get; set; } = new();

    /// <summary></summary>
    public record ValueRangeSuffix
    {
        /// <summary>
        /// <para>指定范围，用于写入数据。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取。</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
        /// <para>**注意**：`range` 所指定的范围需要大于等于插入的数据所占用的范围。但最终增加的行数由 `value` 决定。</para>
        /// <para>**示例值**：`8fe9d6!A2:B5`。该示例值表示在 ID 为 `8fe9d6` 的工作表的第二行（由起始行 A2 决定）上方新增至多四行，在新增行的 A 列和 B 列插入数据。若插入的数据仅有三行，则最终将在第二行上方新增三行。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>插入的数据。如要写入公式、超链接、email、@人等，可参考[支持写入数据类型](https://open.feishu.cn/document/ukTMukTMukTM/ugjN1UjL4YTN14CO2UTN)。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("values")]
        public object[][] Values { get; set; } = Array.Empty<object[]>();
    }
}
