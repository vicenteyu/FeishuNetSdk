namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 向多个范围写入数据 响应体
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "responses": [
            {
                "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
                "updatedCells": 8,
                "updatedColumns": 2,
                "updatedRange": "4FRjKE!A6:B9",
                "updatedRows": 4
            },
            {
                "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
                "updatedCells": 6,
                "updatedColumns": 3,
                "updatedRange": "6e5ed3!A1:C2",
                "updatedRows": 2
            }
        ],
        "revision": 88,
        "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}