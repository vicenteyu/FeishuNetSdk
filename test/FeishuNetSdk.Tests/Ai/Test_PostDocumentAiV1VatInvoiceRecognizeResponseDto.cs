// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocumentAiV1VatInvoiceRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别文件中的增值税发票 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的增值税发票 响应体
/// <para>接口ID：7247054875321434114</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/vat_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fvat_invoice%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1VatInvoiceRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "vat_invoices": [
            {
                "entities": [
                    {
                        "type": "buyer_name",
                        "value": "发呆公司",
                        "items": [
                            [
                                {
                                    "type": "entry_name",
                                    "value": "餐饮服务"
                                }
                            ]
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1VatInvoiceRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}