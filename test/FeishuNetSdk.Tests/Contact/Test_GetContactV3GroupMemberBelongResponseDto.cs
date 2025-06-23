namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询用户所属用户组 响应体
/// <para>接口ID：7106501358249885699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/member_belong</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fmember_belong</para>
/// </summary>
[TestClass]
public class Test_GetContactV3GroupMemberBelongResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "group_list": [
            "og-1455998e138698e1386"
        ],
        "page_token": "AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3GroupMemberBelongResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}