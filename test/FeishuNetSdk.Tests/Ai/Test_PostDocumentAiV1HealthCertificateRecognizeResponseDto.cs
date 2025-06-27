// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocumentAiV1HealthCertificateRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别文件中的健康证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的健康证 响应体
/// <para>接口ID：7319756481343766532</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/health_certificate/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fhealth_certificate%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1HealthCertificateRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "health_certificate": {
            "entities": [
                {
                    "type": "id_number",
                    "value": "张三"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1HealthCertificateRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}