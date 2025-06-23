namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取消息推送概览 响应体
/// <para>接口ID：7036626399368953884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/message_push_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fmessage_push_overview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "items": [
            {
                "metric_name": "send_msg_count",
                "metric_value": 7
            },
            {
                "metric_name": "send_user_count",
                "metric_value": 7
            },
            {
                "metric_name": "read_in_1h_count",
                "metric_value": 20
            },
            {
                "metric_name": "read_in_12h_count",
                "metric_value": 20
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}