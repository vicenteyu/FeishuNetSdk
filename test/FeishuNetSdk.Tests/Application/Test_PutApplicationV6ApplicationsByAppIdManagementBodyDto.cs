// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutApplicationV6ApplicationsByAppIdManagementBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启停用应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 启停用应用 请求体
/// <para>接口ID：7327327802326958081</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/admin/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-management%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutApplicationV6ApplicationsByAppIdManagementBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "enable": true
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PutApplicationV6ApplicationsByAppIdManagementBodyDto>(json);
        Assert.IsNotNull(result);
    }
}