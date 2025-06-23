namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建角色 响应体
/// <para>接口ID：7200215886841135132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3FunctionalRolesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "role_id": "7vrj3vk70xk7v5r"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PostContactV3FunctionalRolesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}