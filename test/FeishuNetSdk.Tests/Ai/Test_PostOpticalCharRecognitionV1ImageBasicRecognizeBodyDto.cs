namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别图片中的文字 请求体
/// <para>接口ID：6949829039872000001</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/optical_char_recognition-v1/basic_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2foptical_char_recognition-v1%2fimage%2fbasic_recognize</para>
/// </summary>
[TestClass]
public class Test_PostOpticalCharRecognitionV1ImageBasicRecognizeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "image": "base64后的图片二进制数据"
}
""";
        var result = Deserialize<FeishuNetSdk.Ai.PostOpticalCharRecognitionV1ImageBasicRecognizeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}