// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取筛选条件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取筛选条件 响应体
/// <para>接口ID：6970504825797623811</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/spreadsheet-sheet-filter_view-condition/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view-condition%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "condition": {
            "condition_id": "E",
            "filter_type": "number",
            "compare_type": "less",
            "expected": [
                "6"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}