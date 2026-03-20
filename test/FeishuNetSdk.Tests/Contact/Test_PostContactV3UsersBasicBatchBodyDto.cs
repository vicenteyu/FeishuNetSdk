namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 通过 ID 获取用户姓名 请求体
/// <para>接口ID：7616208028610694095</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/basic_batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbasic_batch</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UsersBasicBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "ou_b3b46653c99f1f6177a478974bdabb72"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3UsersBasicBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}