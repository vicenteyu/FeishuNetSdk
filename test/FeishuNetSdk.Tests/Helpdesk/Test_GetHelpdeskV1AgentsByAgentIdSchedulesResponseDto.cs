// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1AgentsByAgentIdSchedulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定客服工作日程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 查询指定客服工作日程 响应体
/// <para>接口ID：6955768425688465411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent-schedules/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent-schedules%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1AgentsByAgentIdSchedulesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_schedule": {
            "status": 1,
            "agent": {
                "id": "ou_ea651a5c09e2d01af8acd34059f5359b",
                "avatar_url": "https://avatar-url.com/test.png",
                "name": "test-user",
                "email": "test@bytedance.com",
                "department": "测试部门",
                "company_name": "test-company"
            },
            "schedule": [
                {
                    "start_time": "00:00",
                    "end_time": "24:00",
                    "weekday": 9
                }
            ],
            "agent_skills": [
                {
                    "id": "agent-skill-id",
                    "name": "agent-skill",
                    "is_default": false
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1AgentsByAgentIdSchedulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}