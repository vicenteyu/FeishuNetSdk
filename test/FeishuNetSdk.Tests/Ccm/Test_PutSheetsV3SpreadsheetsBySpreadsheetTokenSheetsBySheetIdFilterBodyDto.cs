namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新筛选 请求体
/// <para>接口ID：6966945328390684674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "col": "G",
    "condition": {
        "filter_type": "text",
        "compare_type": "beginsWith",
        "expected": [
            "a"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto>(json);
        Assert.IsNotNull(result);
    }
}