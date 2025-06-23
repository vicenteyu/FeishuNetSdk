namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起转正 请求体
/// <para>接口ID：7254814386694635522</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsubmit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationSubmitBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "7140964208476371111",
    "conversion_mode": 1,
    "actual_probation_end_date": "2022-05-20",
    "submission_type": "system",
    "initiator_id": "7140964208476371111",
    "notes": "符合预期",
    "self_review": "符合预期",
    "custom_fields": [
        {
            "custom_api_name": "name",
            "name": {
                "zh_cn": "自定义姓名",
                "en_us": "Custom Name"
            },
            "type": 1,
            "value": "231"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationSubmitBodyDto>(json);
        Assert.IsNotNull(result);
    }
}