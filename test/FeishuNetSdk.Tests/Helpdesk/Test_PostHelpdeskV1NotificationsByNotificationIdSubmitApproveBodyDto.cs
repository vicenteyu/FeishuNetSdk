namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 提交审核 请求体
/// <para>接口ID：6999529163292508162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/submit_approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fsubmit_approve</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsByNotificationIdSubmitApproveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reason": "测试发送消息"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsByNotificationIdSubmitApproveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}