namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新背调自定义字段 请求体
/// <para>接口ID：7195815976042594306</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_custom_field/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_custom_field%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EcoBackgroundCheckCustomFieldsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "6995842370159937061",
    "custom_field_list": [
        {
            "type": "select",
            "key": "candidate_degree",
            "name": {
                "zh_cn": "候选人学历",
                "en_us": "Candidate's degree"
            },
            "is_required": true,
            "description": {
                "zh_cn": "候选人真实学历",
                "en_us": "The candidate's real degree"
            },
            "options": [
                {
                    "key": "bachelor",
                    "name": {
                        "zh_cn": "本科",
                        "en_us": "Bachelor"
                    }
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1EcoBackgroundCheckCustomFieldsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}