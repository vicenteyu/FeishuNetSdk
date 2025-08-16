// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-16
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新下拉列表设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 更新下拉列表设置 请求体
/// <para>接口ID：6943917246700322818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/update-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fupdate-datavalidation</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ranges":["BzY8T5!A1:A2", "BzY8T5!B1:B1"],
    "dataValidationType":"list",
    "dataValidation":{
        "conditionValues":["1", "2", "4","2"],
        "options":{
            "multipleValues":false,
            "highlightValidData":true,
            "colors":["#1FB6C1", "#1006C2", "#FB16C3","#FFB6C1"]
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}