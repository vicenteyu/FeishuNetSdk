// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量设置角色成员管理范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量设置角色成员管理范围 请求体
/// <para>接口ID：7200215886841118748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fscopes</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "members": [
        "ou-12832197382"
    ],
    "departments": [
        "ou-12343455"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3FunctionalRolesByRoleIdMembersScopesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}