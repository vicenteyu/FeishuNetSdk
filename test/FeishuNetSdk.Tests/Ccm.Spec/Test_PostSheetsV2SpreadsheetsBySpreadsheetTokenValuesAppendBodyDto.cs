namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 追加数据 请求体
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "valueRange": {
        "range": "Q7PlXT!A1:B4",
        "values": [
            [
                "===",
                "https://www.xxx.com/"
            ],
            [
                "Hello",
                "https://www.xxx.com/"
            ],
            [
                "World",
                "https://www.xxx.com/"
            ],
            [
                "===",
                "https://www.xxx.com/"
            ]
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}