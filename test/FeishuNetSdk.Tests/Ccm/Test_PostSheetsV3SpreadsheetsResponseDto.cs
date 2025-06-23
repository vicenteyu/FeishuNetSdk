namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建电子表格 响应体
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "spreadsheet": {
            "title": "Sales sheet",
            "folder_token": "fldbcO1UuPz8VwnpPx5a92abcef",
            "url": "https://example.feishu.cn/sheets/Iow7sNNEphp3WbtnbCscPqabcef",
            "spreadsheet_token": "Iow7sNNEphp3WbtnbCscPqabcef"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}