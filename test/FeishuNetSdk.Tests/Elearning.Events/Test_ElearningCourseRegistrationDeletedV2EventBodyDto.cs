namespace FeishuNetSdk.Tests.Elearning.Events;

/// <summary>
/// 测试 课程学习进度删除事件 事件体
/// <para>接口ID：7345679561005432835</para>
/// <para>文档地址：https://open.feishu.cn/document/elearning-v2/course_registration/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2felearning-v2%2fcourse_registration%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_ElearningCourseRegistrationDeletedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "elearning.course_registration.deleted_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "course_id": "5fd087e96dbe3a73394188ae",
        "learner": {
            "user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "email": "abc@bytedance.com",
            "phone": "+8618912345678"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Elearning.Events.ElearningCourseRegistrationDeletedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}