namespace FeishuNetSdk.Tests.Moments.Events;

/// <summary>
/// 测试 帖子统计数据变更 事件体
/// <para>接口ID：7270433540692787203</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post_statistics/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost_statistics%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_MomentsPostStatisticsUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "moments.post_statistics.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "post_id": "111111",
        "statistics_type": 1,
        "statistics": {
            "share_count": 10
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Moments.Events.MomentsPostStatisticsUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}