namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移动行列 请求体
/// <para>接口ID：6969403095454416924</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/move_dimension</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fmove_dimension</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "source": {
        "major_dimension": "ROWS",
        "start_index": 0,
        "end_index": 1
    },
    "destination_index": 4
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}