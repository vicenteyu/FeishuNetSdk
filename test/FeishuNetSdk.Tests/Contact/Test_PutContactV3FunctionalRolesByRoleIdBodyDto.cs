// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutContactV3FunctionalRolesByRoleIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改角色名称 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 修改角色名称 请求体
/// <para>接口ID：7200215886841085980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3FunctionalRolesByRoleIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "role_name": "考勤管理员"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PutContactV3FunctionalRolesByRoleIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}