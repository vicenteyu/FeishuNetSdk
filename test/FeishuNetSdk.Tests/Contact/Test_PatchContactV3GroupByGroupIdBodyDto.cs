namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新用户组 请求体
/// <para>接口ID：7008085931593007107</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3GroupByGroupIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "外包 IT 用户组",
    "description": "IT 外包用户组，需要进行细粒度权限管控"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3GroupByGroupIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}