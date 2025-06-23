namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 识别文件中的简历信息 响应体
/// <para>接口ID：7340987945434742812</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/resume/parse</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fresume%2fparse</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1ResumeParseResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "resumes": [
            {
                "file_md5": "825c59042dxxxxx3ff90b45xxxxx88",
                "content": "XX负责行政人事管理和日常事务...",
                "new_content": "XX负责行政人事管理和日常事务...",
                "name": "张三",
                "email": "zhangsan.1111@company.com",
                "mobile": "13600000000",
                "mobile_is_virtual": false,
                "country_code": "86",
                "educations": [
                    {
                        "school": "A大学",
                        "start_date": "2020-01-03",
                        "start_time": "2020-01-03",
                        "end_date": "2021-01-03",
                        "end_time": "至今",
                        "major": "XX工程",
                        "degree": "本科",
                        "qualification": 6
                    }
                ],
                "careers": [
                    {
                        "company": "XX公司",
                        "start_date": "2022-01-03",
                        "start_time": "2022-01-03",
                        "end_date": "2023-01-03",
                        "end_time": "2023-01-03",
                        "title": "XXX工程师",
                        "type": 2,
                        "type_str": "全职",
                        "job_description": "负责XXX开发..."
                    }
                ],
                "projects": [
                    {
                        "name": "XX项目",
                        "title": "客户端研发",
                        "start_date": "2023-01-03",
                        "start_time": "2023-01-03",
                        "end_date": "2023-01-04",
                        "end_time": "2023-01-04",
                        "description": "XXX项目是一个..."
                    }
                ],
                "work_year": 5,
                "date_of_birth": "1995-01-01",
                "gender": 1,
                "willing_positions": [
                    "XX岗位"
                ],
                "current_location": "上海",
                "willing_locations": [
                    "上海"
                ],
                "home_location": "上海",
                "languages": [
                    {
                        "level": 2,
                        "description": "英语四级:600"
                    }
                ],
                "awards": [
                    {
                        "award": "XXX大赛奖项",
                        "date": "2015",
                        "description": "曾获XXX大赛奖项..."
                    }
                ],
                "certificates": [
                    {
                        "name": "XXX证书",
                        "desc": "曾获得XXX证书..."
                    }
                ],
                "competitions": [
                    {
                        "name": "XXX竞赛",
                        "desc": "曾参加XXX竞赛..."
                    }
                ],
                "self_evaluation": "我是一个...",
                "urls": [
                    "https://github.com/"
                ],
                "social_links": [
                    "https://github.com/"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1ResumeParseResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}