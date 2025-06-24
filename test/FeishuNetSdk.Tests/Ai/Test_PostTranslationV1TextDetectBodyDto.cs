// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTranslationV1TextDetectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别文本语种 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文本语种 请求体
/// <para>接口ID：6949829039872049153</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/detect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2fdetect</para>
/// </summary>
[TestClass]
public class Test_PostTranslationV1TextDetectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "text": "你好"
}
""";
        var result = Deserialize<FeishuNetSdk.Ai.PostTranslationV1TextDetectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}