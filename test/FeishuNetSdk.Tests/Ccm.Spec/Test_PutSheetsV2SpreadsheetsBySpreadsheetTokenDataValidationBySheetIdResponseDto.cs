// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-16
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 更新下拉列表设置 响应体
/// <para>接口ID：6943917246700322818</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/update-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fupdate-datavalidation</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "dataValidation": {
            "conditionValues": [
                "1",
                "2",
                "4"
            ],
            "dataValidationType": "list",
            "options": {
                "colorValueMap": {
                    "1": "#1FB6C1",
                    "2": "#1006C2",
                    "4": "#FB16C3"
                },
                "highlightValidData": true,
                "multipleValues": false
            }
        },
        "sheetId": "yuNGtr",
        "spreadsheetToken": "shtbckBcolBlRfkcMVZbolMdADe"
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}