namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新人才 请求体
/// <para>接口ID：7034053347989487644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_update</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsCombinedUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "7158793341499426348",
    "init_source_id": "1",
    "folder_id_list": [
        "702551782317613290"
    ],
    "operator_id": "ou_84aad35d084aa403a838cf73ee18467",
    "operator_account_type": 1,
    "resume_attachment_id": "7383906146040678700",
    "basic_info": {
        "name": "张三",
        "mobile": "182900291190",
        "mobile_country_code": "CN_1",
        "email": "16xx1@126.com",
        "identification": {
            "identification_type": 1,
            "identification_number": "511699199x1x111234"
        },
        "start_work_time": "293016767159",
        "birthday": "293016767159",
        "gender": 1,
        "nationality_id": "CN_112",
        "current_city_code": "CT_159",
        "hometown_city_code": "CT_159",
        "customized_data": [
            {
                "object_id": "6934193211960330504",
                "value": "已婚"
            }
        ]
    },
    "education_list": [
        {
            "degree": 1,
            "school": "香港大学",
            "field_of_study": "考古",
            "start_time": "293016767159",
            "end_time": "293016767159",
            "education_type": 1,
            "academic_ranking": 5,
            "customized_data": [
                {
                    "object_id": "6934193211960330505",
                    "value": "C9"
                }
            ]
        }
    ],
    "career_list": [
        {
            "company": "明日科技公司",
            "title": "高级工程师",
            "desc": "测试",
            "start_time": "293016767159",
            "end_time": "293016767159",
            "career_type": 1,
            "customized_data": [
                {
                    "object_id": "6934193211960330506",
                    "value": "[\"1577808000000\", \"1612108800000\"]"
                }
            ]
        }
    ],
    "project_list": [
        {
            "name": "系统稳定性提升项目",
            "role": "研发人员",
            "link": "https://www.a.com",
            "desc": "该项目目标是提升整个系统的稳定性，达到行业一流水准。",
            "start_time": "293016767159",
            "end_time": "293016767159",
            "customized_data": [
                {
                    "object_id": "6934193211960330507",
                    "value": "1627379423000"
                }
            ]
        }
    ],
    "works_list": [
        {
            "link": "https://www.a.com",
            "desc": "个人设计作品",
            "attachment_id": "12345678",
            "customized_data": [
                {
                    "object_id": "6934193211960330508",
                    "value": "1627379423000"
                }
            ]
        }
    ],
    "award_list": [
        {
            "title": "最佳新人奖",
            "award_time": "293016767159",
            "desc": "最优秀的新人奖",
            "customized_data": [
                {
                    "object_id": "6934193211960330509",
                    "value": "奖项含金量很高"
                }
            ]
        }
    ],
    "language_list": [
        {
            "language": 1,
            "proficiency": 1,
            "customized_data": [
                {
                    "object_id": "6934193211960330510",
                    "value": "3"
                }
            ]
        }
    ],
    "sns_list": [
        {
            "sns_type": 1,
            "link": "https://www.a.com",
            "customized_data": [
                {
                    "object_id": "6934193211960330511",
                    "value": "常用的社交账号"
                }
            ]
        }
    ],
    "preferred_city_code_list": [
        "CT_2"
    ],
    "self_evaluation": {
        "content": "自我评价：平常心",
        "customized_data": [
            {
                "object_id": "6934193211960330512",
                "value": "1"
            }
        ]
    },
    "customized_data": [
        {
            "object_id": "6934193211960330504",
            "children": [
                [
                    {
                        "object_id": "6934193211960330513",
                        "value": "[\"1\", \"2\"]"
                    }
                ]
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentsCombinedUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}