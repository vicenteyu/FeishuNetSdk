namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 替换单元格 响应体
/// <para>接口ID：6982374372208607234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/replace</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet%2freplace</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "replace_result": {
            "matched_cells": [
                "A1"
            ],
            "matched_formula_cells": [
                "B3"
            ],
            "rows_count": 2
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}