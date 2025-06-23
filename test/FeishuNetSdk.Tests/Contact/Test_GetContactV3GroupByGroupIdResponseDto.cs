namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 查询指定用户组 响应体
/// <para>接口ID：7008085931593023491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fget</para>
/// </summary>
[TestClass]
public class Test_GetContactV3GroupByGroupIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "group": {
            "id": "g193821",
            "name": "IT 外包组",
            "description": "IT 外包组，需要对该组人群进行细颗粒度权限管控。",
            "member_user_count": 2,
            "member_department_count": 0,
            "type": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3GroupByGroupIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}