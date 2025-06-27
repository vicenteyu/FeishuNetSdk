// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建筛选视图 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建筛选视图 请求体
/// <para>接口ID：6970504825797672963</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-filter_view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-filter_view%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter_view_id": "pH9hbVcCXA",
    "filter_view_name": "筛选视图 1",
    "range": "8fe9d6!C1:H14"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}