namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的行驶证 响应体
/// <para>接口ID：7249730096956669955</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/vehicle_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fvehicle_license%2frecognize</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1VehicleLicenseRecognizeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "vehicle_license": {
            "entities": [
                {
                    "type": "vehicle_type",
                    "value": "小型普通客车"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1VehicleLicenseRecognizeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}