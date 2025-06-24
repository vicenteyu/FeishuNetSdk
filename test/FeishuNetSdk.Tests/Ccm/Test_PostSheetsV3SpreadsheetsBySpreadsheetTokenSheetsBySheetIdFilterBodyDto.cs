// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建筛选 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建筛选 请求体
/// <para>接口ID：6966945328390668290</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "range": "8fe9d6!A1:H14",
    "col": "E",
    "condition": {
        "filter_type": "number",
        "compare_type": "less",
        "expected": [
            "50%"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto>(json);
        Assert.IsNotNull(result);
    }
}