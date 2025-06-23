namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建推送 响应体
/// <para>接口ID：6999529163292639234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "notification_id": "6985032626234982420",
        "status": 0
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}