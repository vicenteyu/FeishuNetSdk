namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 更新表格属性 响应体
/// <para>接口ID：6907569742384201730</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/update-spreadsheet-properties</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucTMzUjL3EzM14yNxMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "spreadsheetToken": "***",
        "title": "***"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}