// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocumentAiV1FoodManageLicenseRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 识别文件中的食品经营许可证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的食品经营许可证 响应体
/// <para>接口ID：7249730096956719107</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/food_manage_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ffood_manage_license%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1FoodManageLicenseRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "food_manage_license": {
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1FoodManageLicenseRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}