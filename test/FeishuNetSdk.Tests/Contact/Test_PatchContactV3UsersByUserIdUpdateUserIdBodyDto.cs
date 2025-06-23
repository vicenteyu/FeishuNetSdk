namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新用户 ID 请求体
/// <para>接口ID：7257363132833300482</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/user/update_user_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fupdate_user_id</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3UsersByUserIdUpdateUserIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "new_user_id": "3e3cf96b"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3UsersByUserIdUpdateUserIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}