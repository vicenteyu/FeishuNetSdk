// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAilyV1AppsByAppIdSkillsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询技能列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 查询技能列表 响应体
/// <para>接口ID：7429225800963063810</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/app-skill/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppsByAppIdSkillsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "has_more": false,
    "page_token": "skill_cb6685a0ef33",
    "skills": [
      {
        "description": "工作流技能",
        "id": "skill_8c71459001b2",
        "input_schema": "[{\"name\":\"userInput\",\"type\":\"String\",\"required\":true,\"defaultValue\":\"你好\",\"description\":\"\"},{\"name\":\"chatHistory\",\"type\":\"List\",\"required\":true,\"defaultValue\":null,\"description\":\"\"},{\"name\":\"userMessage\",\"type\":\"__SpringUserMessage\",\"required\":false,\"defaultValue\":null,\"description\":\"\"}]",
        "label": "工作流技能",
        "output_schema": "[{\"name\":\"message_status\",\"type\":\"Boolean\",\"required\":false,\"defaultValue\":null,\"description\":\"\"},{\"name\":\"input_message\",\"type\":\"String\",\"required\":false,\"defaultValue\":null,\"description\":\"\"}]",
        "samples": []
      },
      {
        "description": "理解用户提出的问题，对当前助手已经配置的数据资产进行知识搜索、数据分析、文档阅读，总结并返回答案。",
        "id": "skill_cb6685a0ef33",
        "input_schema": "",
        "label": "数据分析和问答",
        "output_schema": "",
        "samples": []
      }
    ]
  },
  "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppsByAppIdSkillsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}