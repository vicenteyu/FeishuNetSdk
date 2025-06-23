namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的出租车发票 响应体
/// <para>接口ID：7249730096956620803</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/taxi_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ftaxi_invoice%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1TaxiInvoiceRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "taxi_invoices": [
            {
                "entities": [
                    {
                        "type": "car_number",
                        "value": "BDK6231"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1TaxiInvoiceRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}