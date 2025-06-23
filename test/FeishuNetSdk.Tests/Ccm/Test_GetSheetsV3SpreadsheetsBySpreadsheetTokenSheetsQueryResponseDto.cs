namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取工作表 响应体
/// <para>接口ID：7120425077330952220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "sheets": [
            {
                "sheet_id": "sxj5ws",
                "title": "title",
                "index": 0,
                "hidden": false,
                "grid_properties": {
                    "frozen_row_count": 0,
                    "frozen_column_count": 0,
                    "row_count": 200,
                    "column_count": 20
                },
                "resource_type": "sheet",
                "merges": [
                    {
                        "start_row_index": 0,
                        "end_row_index": 0,
                        "start_column_index": 0,
                        "end_column_index": 0
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}