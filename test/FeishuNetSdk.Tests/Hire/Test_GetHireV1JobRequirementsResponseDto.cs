// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobRequirementsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取招聘需求列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘需求列表 响应体
/// <para>接口ID：6989078472837218307</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobRequirementsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "has_more": true,
        "page_token": "1234452132",
        "items": [
            {
                "id": "6949805467799537964",
                "short_code": "xx1",
                "name": "test",
                "display_progress": 1,
                "head_count": 11,
                "recruitment_type": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "实习",
                        "en_us": "practice"
                    }
                },
                "employee_type": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "正式",
                        "en_us": "Regular"
                    }
                },
                "max_level": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "3-1",
                        "en_us": "3-1"
                    }
                },
                "min_level": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "1-1",
                        "en_us": "1-1"
                    }
                },
                "sequence": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "P职能族",
                        "en_us": "P functional family"
                    }
                },
                "category": 1,
                "department": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "华北大区",
                        "en_us": "华北大区-EN"
                    }
                },
                "recruiter_list": [
                    {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "董一二三",
                            "en_us": "dong"
                        }
                    }
                ],
                "jr_hiring_managers": [
                    {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "董一二三",
                            "en_us": "dong"
                        }
                    }
                ],
                "direct_leader_list": [
                    {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "董一二三",
                            "en_us": "dong"
                        }
                    }
                ],
                "start_time": "1625729379000",
                "deadline": "1625729379000",
                "priority": 1,
                "required_degree": 1,
                "max_salary": "123",
                "min_salary": "11",
                "address": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "openAPI 新建地址测试2",
                        "en_us": "openAPI 新建地址测试2"
                    }
                },
                "description": "11",
                "customized_data_list": [
                    {
                        "object_id": "xxxx",
                        "name": {
                            "zh_cn": "单行文本",
                            "en_us": "single line of text"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "text",
                            "option": {
                                "key": "AA",
                                "name": {
                                    "zh_cn": "单行文本",
                                    "en_us": "single line of text"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "AA",
                                    "name": {
                                        "zh_cn": "单行文本",
                                        "en_us": "single line of text"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "AA",
                                "end_time": "AA"
                            },
                            "time": "1625456721000",
                            "number": "111"
                        }
                    }
                ],
                "job_id_list": [
                    "6930815272790114324"
                ],
                "process_type": 1,
                "job_type": {
                    "id": "6930815272790114324",
                    "name": {
                        "zh_cn": "金融",
                        "en_us": "finance"
                    },
                    "parent_id": "6930815272790114323"
                },
                "create_time": "1718856006000",
                "creator_id": "ou_e2fc714c4727ee9395f324cd2e7f331f",
                "update_time": "1718856006000",
                "employment_job_id": "6807407987381831949",
                "position_id": "7094136522860922111",
                "completion_time": "1736846689278",
                "approval_status": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobRequirementsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}