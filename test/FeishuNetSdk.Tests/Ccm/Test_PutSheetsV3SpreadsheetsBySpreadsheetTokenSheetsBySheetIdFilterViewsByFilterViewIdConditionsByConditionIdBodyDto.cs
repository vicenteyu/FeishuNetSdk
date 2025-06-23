namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新筛选条件 请求体
/// <para>接口ID：6970504825797541891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter_type": "number",
    "compare_type": "less",
    "expected": [
        "6"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}