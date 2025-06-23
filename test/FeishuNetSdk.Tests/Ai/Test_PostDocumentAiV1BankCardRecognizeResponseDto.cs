namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的银行卡 响应体
/// <para>接口ID：7273083612789604355</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/bank_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbank_card%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1BankCardRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "bank_card": {
            "entities": [
                {
                    "type": "card_number",
                    "value": "5184********8888"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1BankCardRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}