// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取筛选 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取筛选 响应体
/// <para>接口ID：6966945328390651906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "sheet_filter_info": {
            "range": "8fe9d6!A1:H14",
            "filtered_out_rows": [
                4,
                5,
                6
            ],
            "filter_infos": [
                {
                    "col": "E",
                    "conditions": [
                        {
                            "filter_type": "number",
                            "compare_type": "less",
                            "expected": [
                                "50%"
                            ]
                        }
                    ]
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}