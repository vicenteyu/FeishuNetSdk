// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2ImportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导入表格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 导入表格 请求体
/// <para>接口ID：6907568031544229890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/sheet-operation/import-spreadsheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATO2YjLwkjN24CM5YjN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2ImportBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file": null,
    "name": "name.xlsx",
    "folderToken": "fldxxxxx"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2ImportBodyDto>(json);
        Assert.IsNotNull(result);
    }
}