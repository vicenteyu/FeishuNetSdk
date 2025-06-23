namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量添加角色成员 请求体
/// <para>接口ID：7200215886841053212</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostContactV3FunctionalRolesByRoleIdMembersBatchCreateBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3FunctionalRolesByRoleIdMembersBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}