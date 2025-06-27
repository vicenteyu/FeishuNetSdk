// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询角色下某个成员的管理范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询角色下某个成员的管理范围 响应体
/// <para>接口ID：7200215886841069596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fget</para>
/// </summary>
[TestClass]
public class Test_GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "member": {
            "user_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
            "scope_type": "All",
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}