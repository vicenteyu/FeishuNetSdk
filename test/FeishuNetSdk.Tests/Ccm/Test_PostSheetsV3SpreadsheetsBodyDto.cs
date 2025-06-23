namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建电子表格 请求体
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "title": "Sales sheet",
    "folder_token": "fldbcO1UuPz8VwnpPx5a92abcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}