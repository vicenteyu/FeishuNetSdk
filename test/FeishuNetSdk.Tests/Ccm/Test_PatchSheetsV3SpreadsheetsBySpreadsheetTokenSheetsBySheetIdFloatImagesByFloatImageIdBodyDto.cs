namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新浮动图片 请求体
/// <para>接口ID：6976178542817280003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "float_image_token": "boxcnrHpsg1QDqXAAAyachabcef",
    "range": "ahgsch!A1:A1",
    "width": 100,
    "height": 100,
    "offset_x": 0,
    "offset_y": 0
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}