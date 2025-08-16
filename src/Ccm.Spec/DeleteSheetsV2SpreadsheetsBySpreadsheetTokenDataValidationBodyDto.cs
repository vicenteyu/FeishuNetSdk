// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除下拉列表设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除下拉列表设置 请求体
/// <para>删除电子表格工作表指定范围中下拉列表的设置，但仍保留选项文本。</para>
/// <para>使用限制：单次删除请求可指定多个范围，单个范围指定的单元格不可超过 5,000 个，范围的总数不可超过 100 个。</para>
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto
{
    /// <summary>
    /// <para>指定要删除的下拉列表的范围。可指定多个范围。</para>
    /// <para>**注意**：</para>
    /// <para>- 删除某个范围失败不影响其它范围的执行。响应体中将返回每个范围的执行结果。</para>
    /// <para>- 单个范围指定的单元格不可超过 5,000 个，范围的总数不可超过 100 个。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dataValidationRanges")]
    public DataValidationRange[] DataValidationRanges { get; set; } = Array.Empty<DataValidationRange>();

    /// <summary></summary>
    public record DataValidationRange
    {
        /// <summary>
        /// <para>要删除的下拉列表的范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
        /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
        /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string Range { get; set; } = string.Empty;
    }
}
