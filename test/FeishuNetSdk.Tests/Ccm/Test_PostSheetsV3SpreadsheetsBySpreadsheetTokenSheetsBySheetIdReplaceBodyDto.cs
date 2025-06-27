// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 替换单元格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 替换单元格 请求体
/// <para>接口ID：6982374372208607234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/replace</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2freplace</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "find_condition": {
        "range": "PNIfrm!A1:C5",
        "match_case": true,
        "match_entire_cell": false,
        "search_by_regex": false,
        "include_formulas": false
    },
    "find": "hello",
    "replacement": "world"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto>(json);
        Assert.IsNotNull(result);
    }
}