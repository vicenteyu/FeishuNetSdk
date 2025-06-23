namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 移除用户组成员 请求体
/// <para>接口ID：7008085931593138179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fremove</para>
/// </summary>
[TestClass]
public class Test_PostContactV3GroupByGroupIdMemberRemoveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "user",
    "member_id": "xj82871k",
    "member_id_type": "open_id"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3GroupByGroupIdMemberRemoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}