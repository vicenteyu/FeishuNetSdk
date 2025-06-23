namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 更新客服工作日程 请求体
/// <para>接口ID：6955768425688514563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent-schedules/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent-schedules%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1AgentsByAgentIdSchedulesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "agent_schedule": {
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
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PatchHelpdeskV1AgentsByAgentIdSchedulesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}