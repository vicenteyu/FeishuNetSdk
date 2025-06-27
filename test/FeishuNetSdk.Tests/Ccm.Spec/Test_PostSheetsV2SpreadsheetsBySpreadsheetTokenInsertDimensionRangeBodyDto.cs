// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 插入行列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 插入行列 请求体
/// <para>接口ID：6907569743420194818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/insert-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMzUjL0IzM14CNyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "dimension":{
        "sheetId":"2jm6f6",
        "majorDimension":"ROWS",
        "startIndex":3,
        "endIndex":7
    },
    "inheritStyle":"BEFORE"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}