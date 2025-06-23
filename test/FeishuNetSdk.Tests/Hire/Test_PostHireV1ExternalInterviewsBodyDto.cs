namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部面试 请求体
/// <para>接口ID：6992822583076339715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalInterviewsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_id": "7396034232747641133",
    "external_application_id": "6960663240925956437",
    "participate_status": 1,
    "begin_time": 1618500278638,
    "end_time": 1618500278639,
    "interview_assessments": [
        {
            "username": "张三",
            "conclusion": 1,
            "assessment_dimension_list": [
                {
                    "score": 99,
                    "option": "选项1",
                    "options": [
                        "选项1"
                    ],
                    "content": "不错的面试内容",
                    "assessment_type": 1,
                    "title": "面试测试",
                    "description": "这是一次测试"
                }
            ],
            "content": "第一次面试"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalInterviewsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}