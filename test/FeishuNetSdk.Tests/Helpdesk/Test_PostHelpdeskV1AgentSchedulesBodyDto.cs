namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建客服工作日程 请求体
/// <para>接口ID：6955768425688334339</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent-schedules/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_schedule%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1AgentSchedulesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "agent_schedules": [
        {
            "agent_id": "agent-id",
            "schedule": [
                {
                    "start_time": "00:00",
                    "end_time": "24:00",
                    "weekday": 9
                }
            ],
            "agent_skill_ids": [
                "test-skill-id"
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1AgentSchedulesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}