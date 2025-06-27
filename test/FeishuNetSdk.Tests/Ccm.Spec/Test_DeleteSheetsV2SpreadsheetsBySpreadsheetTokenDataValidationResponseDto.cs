// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除下拉列表设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除下拉列表设置 响应体
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
[TestClass]
public class Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "rangeResults": [
            {
                "msg": "",
                "range": "4d30c6!A10:C10",
                "success": true,
                "updatedCells": 3
            }
        ]
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}