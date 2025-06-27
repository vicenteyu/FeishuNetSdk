// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchApplicationV6ApplicationsByAppIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用分组信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用分组信息 请求体
/// <para>接口ID：6989432329400270849</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV6ApplicationsByAppIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "common_categories": [
        "分析工具"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV6ApplicationsByAppIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}