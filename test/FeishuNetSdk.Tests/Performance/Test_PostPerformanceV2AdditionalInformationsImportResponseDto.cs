namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 批量导入补充信息 响应体
/// <para>接口ID：7371009404255633412</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/additional_information/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fimport</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2AdditionalInformationsImportResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "import_record_id": "7350194523185610771",
        "additional_informations": [
            {
                "item_id": "7350195758357807123",
                "external_id": "6789523104723558912",
                "reviewee_user_id": "ou_3245842393d09e9428ad4655da6e30b3",
                "item": "业绩补充说明",
                "time": "2024-03-12",
                "detailed_description": "销售额增长目标超额完成"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2AdditionalInformationsImportResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}