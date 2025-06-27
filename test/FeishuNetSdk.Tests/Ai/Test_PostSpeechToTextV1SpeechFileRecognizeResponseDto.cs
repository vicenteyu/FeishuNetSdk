// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSpeechToTextV1SpeechFileRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别语音文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别语音文件 响应体
/// <para>接口ID：6949829039872032769</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/file_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2ffile_recognize</para>
/// </summary>
[TestClass]
public class Test_PostSpeechToTextV1SpeechFileRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "recognition_text": "你好，使用飞书吧"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostSpeechToTextV1SpeechFileRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}