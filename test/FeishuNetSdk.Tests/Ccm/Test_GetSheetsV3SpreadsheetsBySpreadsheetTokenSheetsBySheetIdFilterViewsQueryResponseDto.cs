// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询筛选视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查询筛选视图 响应体
/// <para>接口ID：6970504825797574659</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "filter_view_id": "pH9hbVcCXA",
                "filter_view_name": "筛选视图 1",
                "range": "8fe9d6!C1:H14"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}