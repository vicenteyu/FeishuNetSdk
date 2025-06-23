namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 通过手机号或邮箱获取用户 ID 请求体
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UsersBatchGetIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "emails": [
"zhangsan@z.com","lisi@a.com"
    ],
    "mobiles": [
"13011111111","13022222222"
    ],
"include_resigned":true
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3UsersBatchGetIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}