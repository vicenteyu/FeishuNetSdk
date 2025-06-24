// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchApplicationV6ApplicationsByAppIdAppVersionsByVersionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用审核状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用审核状态 请求体
/// <para>接口ID：6989432329400303617</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV6ApplicationsByAppIdAppVersionsByVersionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV6ApplicationsByAppIdAppVersionsByVersionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}