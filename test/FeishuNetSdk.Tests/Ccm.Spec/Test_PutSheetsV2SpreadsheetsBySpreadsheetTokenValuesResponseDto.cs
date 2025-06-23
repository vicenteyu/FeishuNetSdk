namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 向单个范围写入数据 响应体
/// <para>接口ID：6907569745298980866</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-a-single-range</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjMzUjLwIzM14CMyMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "revision": 84,
        "spreadsheetToken": "shtcngNygNfuqhxTBf588jabcef",
        "updatedCells": 4,
        "updatedColumns": 2,
        "updatedRange": "1QXD0s!A1:B2",
        "updatedRows": 2
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}