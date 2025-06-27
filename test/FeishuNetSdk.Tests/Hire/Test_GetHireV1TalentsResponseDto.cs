// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1TalentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取人才列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才列表 响应体
/// <para>接口ID：7001051759612936195</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentsResponseDto : TestBase
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
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==",
        "items": [
            {
                "id": "6891560630172518670",
                "is_in_agency_period": true,
                "is_onboarded": true,
                "basic_info": {
                    "name": "张三",
                    "mobile": "182900291190",
                    "mobile_code": "86",
                    "mobile_country_code": "CN_1",
                    "email": "16xx1@126.com",
                    "experience_years": 5,
                    "age": 22,
                    "nationality": {
                        "nationality_code": "CN_1",
                        "zh_name": "中国",
                        "en_name": "China"
                    },
                    "gender": 1,
                    "current_city": {
                        "city_code": "CT_11",
                        "zh_name": "北京",
                        "en_name": "Beijing"
                    },
                    "hometown_city": {
                        "city_code": "CT_22",
                        "zh_name": "成都",
                        "en_name": "Chengdu"
                    },
                    "preferred_city_list": [
                        {
                            "city_code": "ST_47",
                            "zh_name": "上海",
                            "en_name": "Shanghai"
                        }
                    ],
                    "identification_type": 1,
                    "identification_number": "511699199x1x111234",
                    "birthday": 293016767159,
                    "creator_id": "ou_4c5ec7005d5e476175d5edfd3f1e5206",
                    "marital_status": 1,
                    "current_home_address": "南京路1号",
                    "modify_time": "1634801678103"
                },
                "education_list": [
                    {
                        "id": "6891560630172518670",
                        "degree": 1,
                        "school": "湘港大学",
                        "field_of_study": "考古",
                        "start_time": "1990-01",
                        "end_time": "1994-01",
                        "end_time_v2": "1687180087000",
                        "education_type": 1,
                        "academic_ranking": 5,
                        "tag_list": [
                            1
                        ]
                    }
                ],
                "career_list": [
                    {
                        "id": "6891560630172518670",
                        "company": "明日科技公司",
                        "title": "高级工程师",
                        "desc": "负责公司主页 UI 交互动画设计，行业领先水准",
                        "start_time": "1990-01",
                        "end_time": "1994-01",
                        "career_type": 1,
                        "tag_list": [
                            6
                        ]
                    }
                ],
                "project_list": [
                    {
                        "id": "6891560630172518670",
                        "name": "权限重构项目",
                        "role": "项目负责人",
                        "link": "www.recruitment-demo.com",
                        "desc": "将系统的权限模块进行重构，支持更加灵活的权限控制能力。",
                        "start_time": "1990-01",
                        "end_time": "1991-01"
                    }
                ],
                "works_list": [
                    {
                        "id": "6891560630172518670",
                        "link": "www.test.com",
                        "desc": "全国 UI 设计大赛一等奖",
                        "name": "全国 UI 设计大赛"
                    }
                ],
                "award_list": [
                    {
                        "id": "6891560630172518670",
                        "title": "最佳新人奖",
                        "award_time": "1991",
                        "desc": "最优秀的新人奖"
                    }
                ],
                "language_list": [
                    {
                        "id": "6891560630172518670",
                        "language": 1,
                        "proficiency": 1
                    }
                ],
                "sns_list": [
                    {
                        "id": "6891560630172518670",
                        "sns_type": 1,
                        "link": "www.test.com"
                    }
                ],
                "resume_source_list": [
                    {
                        "id": "6891560630172518670",
                        "zh_name": "猎头",
                        "en_name": "Hunter"
                    }
                ],
                "interview_registration_list": [
                    {
                        "id": "6833685612520950030",
                        "registration_time": 1618494330932
                    }
                ],
                "resume_attachment_id_list": [
                    "64352523512563462"
                ],
                "top_degree": 1,
                "first_degree": 3
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}