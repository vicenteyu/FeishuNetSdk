// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutApplicationV6ApplicationsByAppIdOwnerBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转移应用所有者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 转移应用所有者 请求体
/// <para>接口ID：7320225176225185795</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/application/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-owner%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutApplicationV6ApplicationsByAppIdOwnerBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "owner_id": "ou_84aad35d084aa403a838cf73ee184670"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PutApplicationV6ApplicationsByAppIdOwnerBodyDto>(json);
        Assert.IsNotNull(result);
    }
}