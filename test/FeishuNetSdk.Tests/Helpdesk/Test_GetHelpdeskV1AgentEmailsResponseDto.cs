namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 获取客服邮箱 响应体
/// <para>接口ID：6955768425688399875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent/agent_email</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent%2fagent_email</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1AgentEmailsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agents": {
            "ou_xxx": "xxx",
            "ou_yyy": "yyy"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1AgentEmailsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}