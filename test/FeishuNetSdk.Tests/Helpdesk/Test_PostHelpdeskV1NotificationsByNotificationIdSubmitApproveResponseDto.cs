namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 提交审核 响应体
/// <para>接口ID：6999529163292508162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/submit_approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fsubmit_approve</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsByNotificationIdSubmitApproveResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_access": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsByNotificationIdSubmitApproveResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}