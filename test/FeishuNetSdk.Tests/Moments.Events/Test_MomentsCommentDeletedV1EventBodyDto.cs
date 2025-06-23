namespace FeishuNetSdk.Tests.Moments.Events;

/// <summary>
/// 测试 删除评论 事件体
/// <para>接口ID：7270433540692754435</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/comment/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fcomment%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_MomentsCommentDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "moments.comment.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "id": "248381240",
        "post_id": "248381241"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Moments.Events.MomentsCommentDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}