// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 查询下拉列表设置 响应体
/// <para>接口ID：6943917246700306434</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/query-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fquery-datavalidation</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "dataValidations": [
            {
                "conditionValues": [
                    "true",
                    "2",
                    "1",
                    "33.3333",
                    "ss"
                ],
                "dataValidationId": 3,
                "dataValidationType": "list",
                "options": {
                    "colorValueMap": {
                        "1": "#b1e8fc",
                        "2": "#fed4a4",
                        "33.3333": "#f8e6ab",
                        "ss": "#a9efe6",
                        "true": "#bacefd"
                    },
                    "highlightValidData": true,
                    "multipleValues": true
                }
            }
        ],
        "revision": 78,
        "sheetId": "4d30c6",
        "spreadsheetToken": "shtbckBcolBlRfkcMVZbolMdADe"
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}