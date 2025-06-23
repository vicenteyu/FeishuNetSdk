namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取消息推送概览 请求体
/// <para>接口ID：7036626399368953884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/message_push_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fmessage_push_overview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "cycle_type": 1,
    "date": "2021-11-18",
    "department_id": "od-bb009b4df5431400dc31d3bc8a37e069"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewBodyDto>(json);
        Assert.IsNotNull(result);
    }
}