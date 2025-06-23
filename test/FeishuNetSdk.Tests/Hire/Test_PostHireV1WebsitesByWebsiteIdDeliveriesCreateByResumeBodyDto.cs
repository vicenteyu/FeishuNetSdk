namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网投递 请求体
/// <para>接口ID：6990661791098716163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_resume</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_resume</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_post_id": "6960663240925956636",
    "resume": {
        "internship_list": [
            {
                "desc": "在抖音工作实习3个月，表现优秀",
                "end_time": 1618500278667,
                "start_time": 1609430400000,
                "title": "后端研发实习生",
                "company": "抖音公司",
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ]
            }
        ],
        "basic_info": {
            "nationality_id": "CN_1",
            "start_work_time": 1609430400000,
            "current_home_address": "成都",
            "hometown_city_code": "CT_159",
            "mobile_country_code": "CN_1",
            "identification": {
                "identification_number": "11002030131312312",
                "identification_type": 1
            },
            "marital_status": 1,
            "mobile": "182900291190",
            "current_city_code": "CT_11",
            "experience_years": 3,
            "gender": 1,
            "birthday": 1609430400000,
            "name": "张三",
            "preferred_city_code_list": [
                "CT_12"
            ],
            "resume_source_id": "6982104077248219436",
            "age": 25,
            "customized_data": [
                {
                    "object_id": "6960663240925956649",
                    "value": "AA"
                }
            ],
            "email": "foo@bytedance.com"
        },
        "education_list": [
            {
                "education_type": 1,
                "end_time": 1618500278663,
                "end_time_v2": 1618500278663,
                "field_of_study": "汉语言文学",
                "school": "香港中文大学",
                "start_time": 1609430400000,
                "academic_ranking": 5,
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ],
                "degree": 1
            }
        ],
        "self_evaluation": {
            "content": "自我评价：平常心",
            "customized_data": [
                {
                    "object_id": "6960663240925956649",
                    "value": "AA"
                }
            ]
        },
        "career_list": [
            {
                "desc": "在抖音公司工作了5年，表现优秀",
                "end_time": 1618500278667,
                "start_time": 1609430400000,
                "title": "后端研发工程师",
                "company": "抖音公司",
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ]
            }
        ],
        "customized_data": [
            {
                "object_id": "6960663240925956651",
                "children": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ]
            }
        ],
        "resume_attachment_id": "6960663240925956654",
        "sns_list": [
            {
                "sns_type": 1,
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ],
                "link": "www.toutiao.com"
            }
        ],
        "works_list": [
            {
                "desc": "作品描述：研究生阶段发表了顶刊论文",
                "link": "www.toutiao.com",
                "attachment": {
                    "file_id": "6982104077248219436"
                },
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ]
            }
        ],
        "award_list": [
            {
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ],
                "desc": "ACM国际大学生程序设计竞赛",
                "title": "ACM 亚洲区金牌",
                "award_time": 1609430400000
            }
        ],
        "project_list": [
            {
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ],
                "desc": "项目描述：课程管理系统",
                "end_time": 1618500278669,
                "link": "www.toutiao.com",
                "name": "大学生课程设计",
                "role": "核心开发",
                "start_time": 1609430400000
            }
        ],
        "language_list": [
            {
                "customized_data": [
                    {
                        "object_id": "6960663240925956649",
                        "value": "AA"
                    }
                ],
                "language": 1,
                "proficiency": 1
            }
        ]
    },
    "user_id": "6960663240925956634",
    "application_preferred_city_code_list": [
        "6960663240925956636"
    ],
    "channel_id": "6891560630172518670"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}