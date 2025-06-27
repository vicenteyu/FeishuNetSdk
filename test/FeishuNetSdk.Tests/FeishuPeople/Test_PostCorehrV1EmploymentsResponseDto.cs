// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1EmploymentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建雇佣信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建雇佣信息 响应体
/// <para>接口ID：7072577767343718401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1EmploymentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employment": {
            "prehire_id": "1",
            "employee_type_id": "1",
            "tenure": "1",
            "department_id": "6893014062142064135",
            "job_level_id": "6893014062142064135",
            "work_location_id": "6893014062142064135",
            "job_family_id": "6893014062142064135",
            "job_id": "6893014062142064135",
            "company_id": "6893014062142064135",
            "working_hours_type_id": "6893014062142064135",
            "id": "6893014062142064135",
            "seniority_date": "2020-01-01",
            "employee_number": "1000000",
            "effective_time": "2020-01-01 00:00:00",
            "expiration_time": "2020-01-01 00:00:00",
            "employment_type": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "person_id": "6919733936050406926",
            "probation_period": 9999,
            "on_probation": "true",
            "probation_end_date": "2022-01-01",
            "primary_employment": true,
            "employment_status": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ],
            "work_email_list": [
                {
                    "email": "12456@test.com",
                    "is_primary": true,
                    "is_public": true,
                    "email_usage": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "email_address": "test@163.com",
            "reason_for_offboarding": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "cost_center_list": [
                {
                    "cost_center_id": "6950635856373745165",
                    "rate": 100,
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "ats_application_id": "6838119494196871234",
            "rehire": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "rehire_employment_id": "7051837122449425964"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1EmploymentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}