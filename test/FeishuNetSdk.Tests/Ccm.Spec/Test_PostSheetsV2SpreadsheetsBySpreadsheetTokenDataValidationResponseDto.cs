// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设置下拉列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 设置下拉列表 响应体
/// <para>接口ID：6943917246700290050</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/set-dropdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fset-dropdown</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}