namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 获取技能信息 响应体
/// <para>接口ID：7429225800963047426</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/app-skill/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppsByAppIdSkillsBySkillIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "skill": {
      "description": "工作流技能",
      "id": "skill_8c71459001b2",
      "input_schema": "[{\"name\":\"userInput\",\"type\":\"String\",\"required\":true,\"defaultValue\":\"你好\",\"description\":\"\"},{\"name\":\"chatHistory\",\"type\":\"List\",\"required\":true,\"defaultValue\":null,\"description\":\"\"},{\"name\":\"userMessage\",\"type\":\"__SpringUserMessage\",\"required\":false,\"defaultValue\":null,\"description\":\"\"}]",
      "label": "工作流技能",
      "output_schema": "[{\"name\":\"message_status\",\"type\":\"Boolean\",\"required\":false,\"defaultValue\":null,\"description\":\"\"},{\"name\":\"input_message\",\"type\":\"String\",\"required\":false,\"defaultValue\":null,\"description\":\"\"}]",
      "samples": []
    }
  },
  "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppsByAppIdSkillsBySkillIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}