namespace FeishuNetSdk.Tests.Hire.Spec;

/// <summary>
/// 测试 获取面试记录列表 响应体
/// <para>接口ID：6964286393804931100</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/hire_internal/application-interview/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication-interview%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ApplicationsByApplicationIdInterviewsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "xx",
        "has_more": false,
        "items": [
            {
                "id": "6949805467799537964",
                "begin_time": 1618899376474,
                "end_time": 1618999376474,
                "round": 0,
                "stage_id": "634324253532232",
                "interview_record_list": [
                    {
                        "id": "6949805467799537964",
                        "user_id": "1618899376474",
                        "content": "代码还行，只是不够聪明",
                        "min_job_level_id": "6435238827342432",
                        "max_job_level_id": "643523885843573",
                        "commit_status": 1,
                        "conclusion": 1,
                        "interview_score": {
                            "id": "6949805467799537964",
                            "level": 3,
                            "zh_name": "3",
                            "zh_description": "通过, 能力达到要求, 建议录用",
                            "en_name": "three",
                            "en_description": "Pass, ability to meet the requirements, suggest to hire"
                        }
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.Spec.GetHireV1ApplicationsByApplicationIdInterviewsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}