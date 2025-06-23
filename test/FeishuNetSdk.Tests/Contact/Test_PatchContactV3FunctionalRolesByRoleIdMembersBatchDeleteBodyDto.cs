namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 删除角色下的成员 请求体
/// <para>接口ID：7200215886841102364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "members": [
        "ou-12832197382"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}