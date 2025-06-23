namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 设置单元格样式  响应体
/// <para>接口ID：6907569523176783873</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjMzUjL5IzM14SOyMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "updates": {
            "revision": 89,
            "spreadsheetToken": "shtcngNygNfuqhxTBf588jabcef",
            "updatedCells": 6,
            "updatedColumns": 3,
            "updatedRange": "6e5ed3!A3:C4",
            "updatedRows": 2
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}