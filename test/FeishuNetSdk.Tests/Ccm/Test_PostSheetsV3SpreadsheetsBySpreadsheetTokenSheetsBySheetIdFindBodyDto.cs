namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查找单元格 请求体
/// <para>接口ID：6982374372208590850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/find</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2ffind</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDto : TestBase
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
    "find": "hello"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDto>(json);
        Assert.IsNotNull(result);
    }
}