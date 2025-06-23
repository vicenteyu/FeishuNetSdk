namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询角色下的所有成员信息 响应体
/// <para>接口ID：7200215886840987676</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3FunctionalRolesByRoleIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "members": [
            {
                "user_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                "scope_type": "All",
                "department_ids": [
                    "od-4e6ac4d14bcd5071a37a39de902c7141"
                ]
            }
        ],
        "page_token": "2132323",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3FunctionalRolesByRoleIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}