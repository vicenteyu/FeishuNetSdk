namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部面评 响应体
/// <para>接口ID：6992822583076356099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview_assessment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalInterviewAssessmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "external_interview_assessment": {
            "id": "6989181065243969836",
            "username": "shaojiale",
            "conclusion": 1,
            "assessment_dimension_list": [
                {
                    "score": 99,
                    "option": "opt",
                    "options": [
                        "opt"
                    ],
                    "content": "content",
                    "assessment_type": 1,
                    "title": "title",
                    "description": "desc"
                }
            ],
            "content": "hello world",
            "external_interview_id": "6986199832494934316"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalInterviewAssessmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}