namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的身份证 响应体
/// <para>接口ID：7249730096956637187</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/id_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fid_card%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1IdCardRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id_card": {
            "entities": [
                {
                    "type": "identity_name",
                    "value": "张三"
                }
            ],
            "side": 0,
            "conners": [
                0
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1IdCardRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}