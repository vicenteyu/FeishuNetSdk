namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询外部面试列表 响应体
/// <para>接口ID：7407298680640913411</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-interview-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalInterviewsBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "external_application_id": "6960663240925956437",
                "id": "6960663240925956436",
                "participate_status": 1,
                "begin_time": 1618500278638,
                "end_time": 1618500278639,
                "interview_assessments": [
                    {
                        "id": "6989181065243969836",
                        "username": "张三",
                        "conclusion": 1,
                        "assessment_dimension_list": [
                            {
                                "score": 99,
                                "option": "选项1",
                                "options": [
                                    "选项1"
                                ],
                                "content": "这是一个测试内容",
                                "assessment_type": 1,
                                "title": "心理测试",
                                "description": "心理测试题目"
                            }
                        ],
                        "content": "这是一个心理测试题目"
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalInterviewsBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}