// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV3GroupByGroupIdMemberBatchAddBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量添加用户组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量添加用户组成员 请求体
/// <para>接口ID：7106501358249852931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/batch_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fbatch_add</para>
/// </summary>
[TestClass]
public class Test_PostContactV3GroupByGroupIdMemberBatchAddBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "members": [
        {
            "member_id": "u287xj12",
            "member_type": "user",
            "member_id_type": "user_id"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3GroupByGroupIdMemberBatchAddBodyDto>(json);
        Assert.IsNotNull(result);
    }
}