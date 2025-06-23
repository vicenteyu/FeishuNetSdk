namespace FeishuNetSdk.Tests.Moments.Events;

/// <summary>
/// 测试 发布评论 事件体
/// <para>接口ID：7270433540692738051</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/comment/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fcomment%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_MomentsCommentCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "moments.comment.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "id": "248381240",
        "create_time": "2022-05-23T00:00:00+08:00",
        "post_id": "248381241",
        "reply_comment_id": "248381242",
        "root_comment_id": "248381243",
        "user_type": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Moments.Events.MomentsCommentCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}