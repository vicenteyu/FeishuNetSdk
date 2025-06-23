namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 批量删除补充信息 响应体
/// <para>接口ID：7371009404255600644</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/additional_information/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_informations-batch%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeletePerformanceV2AdditionalInformationsBatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "additional_informations": [
            "7350195758357807123"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.DeletePerformanceV2AdditionalInformationsBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}