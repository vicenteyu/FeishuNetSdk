namespace FeishuNetSdk.Tests.Ehr;

/// <summary>
/// 测试 批量获取员工花名册信息 响应体
/// <para>接口ID：6948366696944648195</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ehr-v1/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fehr%2fehr-v1%2femployee%2flist</para>
/// </summary>
[TestClass]
public class Test_GetEhrV1EmployeesResponseDto : TestBase
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
                "user_id": "ou_db362c0e79f5a26db1ca8e94698ee417",
                "system_fields": {
                    "name": "张三",
                    "en_name": "Tony Zhang",
                    "email": "a@b.com",
                    "mobile": "(+86) 13812345678",
                    "department_id": "od-4d551617a5da3cec26666d33175dc8ca",
                    "manager": {
                        "user_id": "ou_db362c0e79f5a26db1ca8e94698ee417",
                        "name": "李四",
                        "en_name": "Tom Li"
                    },
                    "job": {
                        "id": 1695838220091399,
                        "name": "测试工程师"
                    },
                    "job_level": {
                        "id": 1695838220091399,
                        "name": "CEO"
                    },
                    "work_location": {
                        "id": 1695838220091399,
                        "name": "武汉"
                    },
                    "gender": 1,
                    "birthday": "2020-01-01",
                    "native_region": {
                        "iso_code": "CHN-11",
                        "name": "北京"
                    },
                    "ethnicity": 2,
                    "marital_status": 2,
                    "political_status": 2,
                    "entered_workforce_date": "2020-01-01",
                    "id_type": 1,
                    "id_number": "110122XXXXXX",
                    "hukou_type": 1,
                    "hukou_location": "北京市海淀区XXXX",
                    "bank_account_number": "1243253453",
                    "bank_name": "招商银行",
                    "social_security_account": "123124124",
                    "provident_fund_account": "123124235",
                    "employee_no": "TM-00001",
                    "employee_type": 1,
                    "status": 2,
                    "hire_date": "2020-01-01",
                    "probation_months": 2,
                    "conversion_date": "2020-01-01",
                    "application": 1,
                    "application_status": 2,
                    "last_day": "2020-01-01",
                    "departure_type": 1,
                    "departure_reason": 4,
                    "departure_notes": "世界那么大",
                    "contract_company": {
                        "id": 1695838220091399,
                        "name": "油条一号"
                    },
                    "contract_type": 1,
                    "contract_start_date": "2020-01-01",
                    "contract_expiration_date": "2020-01-01",
                    "contract_sign_times": 2,
                    "personal_email": "personal@email.com",
                    "family_address": "北京市海淀区XXXXX",
                    "primary_emergency_contact": {
                        "name": "张三",
                        "relationship": 1,
                        "mobile": "(+86) 13812345678"
                    },
                    "emergency_contact": [
                        {
                            "name": "张三",
                            "relationship": 1,
                            "mobile": "(+86) 13812345678"
                        }
                    ],
                    "highest_level_of_edu": {
                        "level": 8,
                        "school": "XXXX大学",
                        "major": "XXX专业",
                        "degree": 2,
                        "start": "2020-01-01",
                        "end": "2020-01-01"
                    },
                    "education": [
                        {
                            "level": 8,
                            "school": "XXXX大学",
                            "major": "XXX专业",
                            "degree": 2,
                            "start": "2020-01-01",
                            "end": "2020-01-01"
                        }
                    ],
                    "former_work_exp": {
                        "company": "XXXX公司",
                        "department": "部门1",
                        "job": "职位",
                        "start": "2020-01-01",
                        "end": "2020-01-01",
                        "description": "工作描述"
                    },
                    "work_exp": [
                        {
                            "company": "XXXX公司",
                            "department": "部门1",
                            "job": "职位",
                            "start": "2020-01-01",
                            "end": "2020-01-01",
                            "description": "工作描述"
                        }
                    ],
                    "id_photo_po_side": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "id_photo_em_side": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "id_photo": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "diploma_photo": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "graduation_cert": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "cert_of_merit": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "offboarding_file": [
                        {
                            "id": "c7273e07ed9e40a394f88c7dccb49212",
                            "mime_type": "png",
                            "name": "Custom Code.png",
                            "size": 57380
                        }
                    ],
                    "cancel_onboarding_reason": 2,
                    "cancel_onboarding_notes": "个人原因",
                    "employee_form_status": 1,
                    "create_time": 1608690517811,
                    "update_time": 1608690517811
                },
                "custom_fields": [
                    {
                        "key": "field_xxxxxxxx",
                        "label": "自定义字段 1",
                        "type": "date",
                        "value": "2021-01-13"
                    }
                ]
            }
        ],
        "page_token": "10",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ehr.GetEhrV1EmployeesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}