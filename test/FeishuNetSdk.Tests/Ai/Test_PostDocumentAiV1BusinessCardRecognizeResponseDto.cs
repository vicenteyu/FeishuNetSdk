namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的名片 响应体
/// <para>接口ID：7205462689421066244</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/business_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbusiness_card%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1BusinessCardRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "business_cards": [
            {
                "entities": [
                    {
                        "type": "contact_names",
                        "value": "张三"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1BusinessCardRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}