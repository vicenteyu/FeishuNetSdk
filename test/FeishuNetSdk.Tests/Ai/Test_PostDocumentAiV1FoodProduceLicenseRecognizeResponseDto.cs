namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的食品生产许可证 响应体
/// <para>接口ID：7249730096956702723</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/food_produce_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ffood_produce_license%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1FoodProduceLicenseRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "food_produce_license": {
            "entities": [
                {
                    "type": "issuer",
                    "value": "张三"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1FoodProduceLicenseRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}