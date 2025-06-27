// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除角色下的成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 删除角色下的成员 响应体
/// <para>接口ID：7200215886841102364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "result": [
            {
                "user_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                "reason": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PatchContactV3FunctionalRolesByRoleIdMembersBatchDeleteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}