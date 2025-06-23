namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 更新行列 请求体
/// <para>接口ID：6907569742383562754</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/update-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYjMzUjL2IzM14iNyMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "dimension":{
        "sheetId":"2jm6f6",
        "majorDimension":"ROWS",
        "startIndex":1,
        "endIndex":3
    },
    "dimensionProperties":{
        "visible":true,
        "fixedSize":50
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}