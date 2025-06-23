namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 读取单个范围 响应体
/// <para>接口ID：6907569742384529410</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/reading-a-single-range</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugTMzUjL4EzM14COxMTN</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesByRangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "revision": 7,
        "spreadsheetToken": "XUMasQlMYhOnMbt5htXc96h0nOg",
        "valueRange": {
            "majorDimension": "ROWS",
            "range": "Q7PlXT!A1:B2",
            "revision": 7,
            "values": [
                [
                    "单元格A1",
                    "单元格B1"
                ],
                [
                    "单元格A2",
                    "单元格B2"
                ]
            ]
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesByRangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}