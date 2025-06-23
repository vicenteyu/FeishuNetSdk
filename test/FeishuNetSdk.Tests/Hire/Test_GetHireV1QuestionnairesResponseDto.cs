namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试满意度问卷列表 响应体
/// <para>接口ID：7039624673445920771</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fquestionnaire%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1QuestionnairesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTcyMzU1OTE4OTg1NCwiaWQiOm51bGx9",
        "items": [
            {
                "questionnaire_id": "7037986982531778860",
                "application_id": "6985833807195212076",
                "interview_id": "7038435261598763308",
                "version": 59,
                "questions": [
                    {
                        "question_id": "6950930570311829804",
                        "question_name": "你的总体评价如何？",
                        "question_en_name": "How would you describe your overall experience?",
                        "question_desc": "测试描述内容",
                        "question_en_desc": "Test Text",
                        "question_type": 4,
                        "is_required": true,
                        "select_option_result_list": [
                            {
                                "option_id": "6950930570311993644",
                                "option_name": "选项一",
                                "option_en_name": "Option 1",
                                "option_desc": "测试选项描述",
                                "option_en_desc": "Test Option Desc",
                                "is_selected": true
                            }
                        ],
                        "five_start_scoring_result": {
                            "highest_score_desc": "非常好",
                            "highest_score_en_desc": "Very Good",
                            "lowest_score_desc": "非常差",
                            "lowest_score_en_desc": "Very Bad",
                            "score_result": 4
                        },
                        "description_result": "测试描述内容"
                    }
                ],
                "has_answers": true,
                "update_time": "1644412504000"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1QuestionnairesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}