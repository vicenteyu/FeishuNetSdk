namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新外部面评 响应体
/// <para>接口ID：7270722035910328322</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-interview-info/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview_assessment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1ExternalInterviewAssessmentsByExternalInterviewAssessmentIdResponseDto : TestBase
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
                        "opt1"
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PatchHireV1ExternalInterviewAssessmentsByExternalInterviewAssessmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}