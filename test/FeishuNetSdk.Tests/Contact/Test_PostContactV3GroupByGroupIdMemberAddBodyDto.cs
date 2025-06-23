namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 添加用户组成员 请求体
/// <para>接口ID：7008085931593056259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fadd</para>
/// </summary>
[TestClass]
public class Test_PostContactV3GroupByGroupIdMemberAddBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "user",
    "member_id_type": "open_id",
    "member_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3GroupByGroupIdMemberAddBodyDto>(json);
        Assert.IsNotNull(result);
    }
}