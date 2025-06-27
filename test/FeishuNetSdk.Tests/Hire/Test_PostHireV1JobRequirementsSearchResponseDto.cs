// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobRequirementsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取招聘需求信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘需求信息 响应体
/// <para>接口ID：7218888199548633092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list_by_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist_by_id</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobRequirementsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
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
                        "zh_cn": "实习",
                        "en_us": "practice"
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
                    "id": "1-1",
                    "name": {
                        "zh_cn": "1-1",
                        "en_us": "1-1"
                    }
                },
                "sequence": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "自定义字段",
                        "en_us": "customized data"
                    }
                },
                "category": 1,
                "department": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "测试部门",
                        "en_us": "test department"
                    }
                },
                "recruiter_list": [
                    {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "zhangSan"
                        }
                    }
                ],
                "jr_hiring_managers": [
                    {
                        "id": "张三",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "zhangsan"
                        }
                    }
                ],
                "direct_leader_list": [
                    {
                        "id": "张三",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "zhangsan"
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
                        "zh_cn": "北京",
                        "en_us": "BeiJing"
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1JobRequirementsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}