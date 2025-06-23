namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 取消订阅 请求体
/// <para>接口ID：7275929163676254211</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-event/unsubscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-event%2funsubscribe</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdEventUnsubscribeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdEventUnsubscribeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}