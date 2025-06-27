// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3GroupByGroupIdMemberSimplelistResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询用户组成员列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询用户组成员列表 响应体
/// <para>接口ID：7008085931593072643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fsimplelist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3GroupByGroupIdMemberSimplelistResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "memberlist": [
            {
                "member_id": "u287xj12",
                "member_type": "user",
                "member_id_type": "user_id"
            }
        ],
        "page_token": "TDRRV9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiJDGexPw=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3GroupByGroupIdMemberSimplelistResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}