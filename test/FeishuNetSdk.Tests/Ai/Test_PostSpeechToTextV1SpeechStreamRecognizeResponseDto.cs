// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSpeechToTextV1SpeechStreamRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别流式语音 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别流式语音 响应体
/// <para>接口ID：6949829039872016385</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/stream_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2fstream_recognize</para>
/// </summary>
[TestClass]
public class Test_PostSpeechToTextV1SpeechStreamRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "stream_id": "asd1234567890ddd",
        "sequence_id": 1,
        "recognition_text": "你好，尝试使用一下飞书吧"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostSpeechToTextV1SpeechStreamRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}