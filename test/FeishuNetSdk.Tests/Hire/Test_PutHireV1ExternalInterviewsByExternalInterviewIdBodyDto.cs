namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新外部面试 请求体
/// <para>接口ID：7407298680641011715</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-interview-info/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1ExternalInterviewsByExternalInterviewIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
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
                    "content": "测试内容",
                    "assessment_type": 1,
                    "title": "心理测试",
                    "description": "心理测试描述"
                }
            ],
            "content": "面试内容结果补充"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1ExternalInterviewsByExternalInterviewIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}