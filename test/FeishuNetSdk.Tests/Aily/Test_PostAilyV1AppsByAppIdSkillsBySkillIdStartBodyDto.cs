// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1AppsByAppIdSkillsBySkillIdStartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 调用技能 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 调用技能 请求体
/// <para>接口ID：7429225800963031042</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/app-skill/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fstart</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AppsByAppIdSkillsBySkillIdStartBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "global_variable": {
    "query": "你好"
  }
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1AppsByAppIdSkillsBySkillIdStartBodyDto>(json);
        Assert.IsNotNull(result);
    }
}