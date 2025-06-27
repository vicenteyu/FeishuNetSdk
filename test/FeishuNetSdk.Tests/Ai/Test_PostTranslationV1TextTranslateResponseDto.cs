// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTranslationV1TextTranslateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 翻译文本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 翻译文本 响应体
/// <para>接口ID：6949829039871983617</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/translation-v1/translate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2ftranslation-v1%2ftext%2ftranslate</para>
/// </summary>
[TestClass]
public class Test_PostTranslationV1TextTranslateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "text": "Try to use Lark"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostTranslationV1TextTranslateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}