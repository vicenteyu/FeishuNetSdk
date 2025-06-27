// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocumentAiV1ChinesePassportRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别文件中的中国护照 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的中国护照 响应体
/// <para>接口ID：7273083612789587971</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/chinese_passport/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fchinese_passport%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1ChinesePassportRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "chinese_passport": {
            "entities": [
                {
                    "type": "full_name_cn",
                    "value": "张三"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1ChinesePassportRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}