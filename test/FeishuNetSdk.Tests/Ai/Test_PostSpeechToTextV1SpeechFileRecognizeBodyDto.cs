namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别语音文件 请求体
/// <para>接口ID：6949829039872032769</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/speech_to_text-v1/file_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fspeech_to_text-v1%2fspeech%2ffile_recognize</para>
/// </summary>
[TestClass]
public class Test_PostSpeechToTextV1SpeechFileRecognizeBodyDto : TestBase
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
        "file_id": "qwe12dd34567890w",
        "format": "pcm",
        "engine_type": "16k_auto"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ai.PostSpeechToTextV1SpeechFileRecognizeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}