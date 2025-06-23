namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 订阅事件 请求体
/// <para>接口ID：7275929163676155907</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/subscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2fsubscribe</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdEventSubscribeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdEventSubscribeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}