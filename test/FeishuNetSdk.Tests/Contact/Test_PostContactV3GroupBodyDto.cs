namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建用户组 请求体
/// <para>接口ID：7008085931593089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3GroupBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "IT 外包组",
    "description": "IT服务人员的集合",
    "type": 1,
    "group_id": "g122817"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3GroupBodyDto>(json);
        Assert.IsNotNull(result);
    }
}