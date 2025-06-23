namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试轮次类型列表 响应体
/// <para>接口ID：7098333210140082177</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/interview-settings/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_round_type%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewRoundTypesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "active_status": 1,
        "items": [
            {
                "id": "7012129842917869868",
                "biz_id": "7012129842917869868",
                "name": {
                    "zh_cn": "默认面试轮次类型",
                    "en_us": "default interview round type"
                },
                "process_type": 1,
                "active_status": 1,
                "interview_assessment_template_info": {
                    "id": "7012129842917869868",
                    "biz_id": "7012129842917869868",
                    "name": {
                        "zh_cn": "默认面试评价表",
                        "en_us": "default interview assessment template"
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewRoundTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}