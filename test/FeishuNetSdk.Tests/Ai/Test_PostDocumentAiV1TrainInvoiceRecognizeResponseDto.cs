namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的火车票 响应体
/// <para>接口ID：7249730096956686339</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/train_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ftrain_invoice%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1TrainInvoiceRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "train_invoices": [
            {
                "entities": [
                    {
                        "type": "end_station",
                        "value": "长沙南"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1TrainInvoiceRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}