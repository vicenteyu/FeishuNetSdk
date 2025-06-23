namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取任职信息列表 响应体
/// <para>接口ID：7262387840977207297</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-job_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesJobDatasQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "employment_id": "6893014062142064135",
                "job_datas": [
                    {
                        "job_data_id": "6890452208593372679",
                        "version_id": "6890452208593372697",
                        "employee_type_id": "6890452208593372679",
                        "working_hours_type_id": "6890452208593372679",
                        "work_location_id": "6890452208593372679",
                        "department_id": "6890452208593372679",
                        "position_id": "6890452208593372679",
                        "job_id": "6890452208593372679",
                        "job_level_id": "6890452208593372679",
                        "job_grade_id": "6890452208593372679",
                        "job_family_id": "1245678",
                        "probation_start_date": "2018-03-16T00:00:00",
                        "probation_end_date": "2019-05-24T00:00:00",
                        "primary_job_data": true,
                        "employment_id": "6893014062142064135",
                        "effective_time": "2020-05-01 00:00:00",
                        "expiration_time": "2020-05-02 00:00:00",
                        "assignment_start_reason": {
                            "enum_name": "onboarding",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "probation_expected_end_date": "2006-01-02",
                        "probation_outcome": {
                            "enum_name": "example",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "direct_manager": {
                            "job_data_id": "1000000",
                            "employment_id": "6893014062142064135"
                        },
                        "dotted_line_managers": [
                            {
                                "job_data_id": "1000000",
                                "employment_id": "6893014062142064135"
                            }
                        ],
                        "second_direct_manager": {
                            "job_data_id": "1000000",
                            "employment_id": "6893014062142064135"
                        },
                        "cost_center_rates": [
                            {
                                "cost_center_id": "6950635856373745165",
                                "rate": 100,
                                "new_rate": 50.2
                            }
                        ],
                        "work_shift": {
                            "enum_name": "example",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "compensation_type": {
                            "enum_name": "example",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "service_company": "6890452208593372680",
                        "weekly_working_hours_v2": 10.1,
                        "weekly_working_hours": 10,
                        "employee_subtype_id": "6890452208593372680",
                        "job_data_reason": {
                            "enum_name": "example_option",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "晋升"
                                }
                            ]
                        },
                        "pathway_id": "6890452208593372679"
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EmployeesJobDatasQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}