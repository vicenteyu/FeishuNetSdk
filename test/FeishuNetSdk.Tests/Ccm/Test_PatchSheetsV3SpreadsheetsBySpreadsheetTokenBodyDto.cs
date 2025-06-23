namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 修改电子表格属性 请求体
/// <para>接口ID：7120425077330903068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSheetsV3SpreadsheetsBySpreadsheetTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "title": "Sales sheet"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PatchSheetsV3SpreadsheetsBySpreadsheetTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}