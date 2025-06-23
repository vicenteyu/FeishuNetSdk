namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别流式语音 请求体
/// <para>接口ID：6949829039872016385</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/stream_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2fstream_recognize</para>
/// </summary>
[TestClass]
public class Test_PostSpeechToTextV1SpeechStreamRecognizeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "speech": {
        "speech": "PdmrfE267Cd/Z9KpmNFh71A2PSJZxSp7+8upCg=="
    },
    "config": {
        "stream_id": "asd1234567890ddd",
        "sequence_id": 1,
        "action": 1,
        "format": "pcm",
        "engine_type": "16k_auto"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ai.PostSpeechToTextV1SpeechStreamRecognizeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}