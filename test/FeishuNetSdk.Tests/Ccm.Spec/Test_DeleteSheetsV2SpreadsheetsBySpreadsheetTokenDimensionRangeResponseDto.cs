namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除行列 响应体
/// <para>接口ID：6907569524100382721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/-delete-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucjMzUjL3IzM14yNyMTN</para>
/// </summary>
[TestClass]
public class Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "delCount": 0,
        "majorDimension": "ROWS"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}