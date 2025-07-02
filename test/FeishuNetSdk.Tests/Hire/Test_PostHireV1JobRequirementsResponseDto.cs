// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="Test_PostHireV1JobRequirementsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建招聘需求 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建招聘需求 响应体
/// <para>接口ID：6989078472837283843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobRequirementsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "job_requirement": {
            "id": "6949805467799537964",
            "short_code": "R01905",
            "name": "HR部门春季招聘需求",
            "display_progress": 1,
            "head_count": 10,
            "recruitment_type": {
                "id": "101",
                "name": {
                    "zh_cn": "社招-全职",
                    "en_us": "Social recruitment - Full time"
                }
            },
            "employee_type": {
                "id": "6807409776231254285",
                "name": {
                    "zh_cn": "专家",
                    "en_us": "specialist"
                }
            },
            "max_level": {
                "id": "mga5oa8ayjlp9rb",
                "name": {
                    "zh_cn": "高级专家",
                    "en_us": "senior specialist"
                }
            },
            "min_level": {
                "id": "mga5oa8ayjlp9ra",
                "name": {
                    "zh_cn": "专家",
                    "en_us": "specialist"
                }
            },
            "sequence": {
                "id": "mga5oa8ayjlpzjq",
                "name": {
                    "zh_cn": "产品",
                    "en_us": "product manager"
                }
            },
            "category": 1,
            "department": {
                "id": "D096",
                "name": {
                    "zh_cn": "产品部门",
                    "en_us": "product manager department"
                }
            },
            "recruiter_list": [
                {
                    "id": "ou_a586b1865a876389400de162d8d81071",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "zhangsan"
                    }
                }
            ],
            "jr_hiring_managers": [
                {
                    "id": "ou_a586b1865a876389400de162d8d81071",
                    "name": {
                        "zh_cn": "李四",
                        "en_us": "lisi"
                    }
                }
            ],
            "direct_leader_list": [
                {
                    "id": "ou_a586b1865a876389400de162d8d81071",
                    "name": {
                        "zh_cn": "王五",
                        "en_us": "wangwu"
                    }
                }
            ],
            "start_time": "1625729379000",
            "deadline": "1625729379000",
            "priority": 1,
            "required_degree": 1,
            "max_salary": "10",
            "min_salary": "5",
            "address": {
                "id": "7275291385551945731",
                "name": {
                    "zh_cn": "北京",
                    "en_us": "Beijing"
                }
            },
            "description": "部门人力紧缺，需要招聘资深工程师10名",
            "customized_data_list": [
                {
                    "object_id": "123123123",
                    "name": {
                        "zh_cn": "招聘原因",
                        "en_us": "Recruitment reason"
                    },
                    "object_type": 1,
                    "value": {
                        "content": "人员紧缺程度",
                        "option": {
                            "key": "serious",
                            "name": {
                                "zh_cn": "严重",
                                "en_us": "serious"
                            }
                        },
                        "option_list": [
                            {
                                "key": "serious",
                                "name": {
                                    "zh_cn": "严重",
                                    "en_us": "serious"
                                }
                            }
                        ],
                        "time_range": {
                            "start_time": "1625729379000",
                            "end_time": "1625729380000"
                        },
                        "time": "1625456721000",
                        "number": "100"
                    }
                }
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1JobRequirementsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}