// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除下拉列表设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除下拉列表设置 请求体
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
[TestClass]
public class Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "dataValidationRanges":[
        {
            "range": "4d30c6!A10:C10"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}