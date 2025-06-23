namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 调用技能 响应体
/// <para>接口ID：7429225800963031042</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/app-skill/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fstart</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AppsByAppIdSkillsBySkillIdStartResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "output": "{\"message_status\":true,\"input_message\":\"\"}",
    "status": "success"
  },
  "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1AppsByAppIdSkillsBySkillIdStartResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}