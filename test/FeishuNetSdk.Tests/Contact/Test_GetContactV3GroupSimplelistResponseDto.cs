namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询用户组列表 响应体
/// <para>接口ID：7008085931593039875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fsimplelist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3GroupSimplelistResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "grouplist": [
            {
                "id": "g193821",
                "name": "IT 外包组",
                "description": "IT 外包组，需要对该组人群进行细颗粒度权限管控。",
                "member_user_count": 2,
                "member_department_count": 0,
                "type": 1,
                "department_scope_list": [
                    "od-4e6ac4d14bcd5071a37a39de902c7141"
                ],
                "group_id": "4ba51ab38648f9cd"
            }
        ],
        "page_token": "AQD9/Rn9556539ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JDTJJDDPw=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3GroupSimplelistResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}