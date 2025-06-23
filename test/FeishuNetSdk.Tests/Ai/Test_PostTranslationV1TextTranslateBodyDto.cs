namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 翻译文本 请求体
/// <para>接口ID：6949829039871983617</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/translate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2ftranslate</para>
/// </summary>
[TestClass]
public class Test_PostTranslationV1TextTranslateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "source_language": "zh",
    "text": "尝试使用一下飞书吧",
    "target_language": "en",
    "glossary": [
        {
            "from": "飞书",
            "to": "Lark"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ai.PostTranslationV1TextTranslateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}