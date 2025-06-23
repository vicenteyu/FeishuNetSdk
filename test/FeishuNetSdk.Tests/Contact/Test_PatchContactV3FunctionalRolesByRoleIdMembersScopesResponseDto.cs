namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量设置角色成员管理范围 响应体
/// <para>接口ID：7200215886841118748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fscopes</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3FunctionalRolesByRoleIdMembersScopesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "results": [
            {
                "user_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                "reason": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PatchContactV3FunctionalRolesByRoleIdMembersScopesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}