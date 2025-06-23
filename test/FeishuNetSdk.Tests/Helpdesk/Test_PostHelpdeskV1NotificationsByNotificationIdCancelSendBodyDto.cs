namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 取消推送 请求体
/// <para>接口ID：6999529163292557314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/cancel_send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fcancel_send</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsByNotificationIdCancelSendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "is_recall": true
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsByNotificationIdCancelSendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}