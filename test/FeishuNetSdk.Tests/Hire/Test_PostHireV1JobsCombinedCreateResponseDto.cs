namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建职位 响应体
/// <para>接口ID：7012986483075481601</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_create</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsCombinedCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "default_job_post": {
            "id": "6960663240925956568"
        },
        "job": {
            "id": "7281257045172308287",
            "title": "测试职位",
            "description": "这是一个测试职位",
            "code": "Z188",
            "requirement": "要求高学历人才",
            "recruitment_type": {
                "id": "7281257045172308287",
                "zh_name": "全职",
                "en_name": "FullTime",
                "active_status": 1
            },
            "department": {
                "id": "7281257045172308287",
                "zh_name": "字节跳动",
                "en_name": "Bytedance"
            },
            "city": {
                "city_code": "CT_20",
                "zh_name": "成都",
                "en_name": "Chengdu"
            },
            "min_job_level": {
                "id": "7281257045172308287",
                "zh_name": "级别-2",
                "en_name": "level-2",
                "active_status": 1
            },
            "max_job_level": {
                "id": "7281257045172308287",
                "zh_name": "级别-2",
                "en_name": "level-2",
                "active_status": 1
            },
            "highlight_list": [
                {
                    "id": "7281257045172308287",
                    "zh_name": "团队氛围好",
                    "en_name": "Positive team atmosphere"
                }
            ],
            "job_category": {
                "id": "7281257045172308287",
                "zh_name": "序列-A",
                "en_name": "category-A",
                "active_status": 1
            },
            "job_type": {
                "id": "6890840777044265230",
                "zh_name": "金融",
                "en_name": "Finance"
            },
            "active_status": 1,
            "create_user_id": "7281257045172308287",
            "create_time": 1617170925462,
            "update_time": 1617170925462,
            "process_type": 1,
            "process_id": "1",
            "process_name": "流程中文名",
            "process_en_name": "流程英文名",
            "customized_data_list": [
                {
                    "object_id": "7281257045172308287",
                    "name": {
                        "zh_cn": "职位特殊要求",
                        "en_us": "field 1"
                    },
                    "object_type": 1,
                    "value": {
                        "content": "这是一个单行文本",
                        "option": {
                            "key": "7281257045172308287",
                            "name": {
                                "zh_cn": "选项 A",
                                "en_us": "Option A"
                            }
                        },
                        "option_list": [
                            {
                                "key": "7281257045172308287",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "Option A"
                                }
                            }
                        ],
                        "time_range": {
                            "start_time": "1622484739955",
                            "end_time": "1622484739955"
                        },
                        "time": "1625456721000",
                        "number": "111"
                    }
                }
            ],
            "job_function": {
                "id": "7281257045172308287",
                "name": {
                    "zh_cn": "测试职能",
                    "en_us": "test job function"
                }
            },
            "subject": {
                "id": "7281257045172308287",
                "name": {
                    "zh_cn": "测试项目",
                    "en_us": "test subject"
                }
            },
            "head_count": 100,
            "experience": 1,
            "expiry_time": 1622484739955,
            "min_salary": 10,
            "max_salary": 20,
            "required_degree": 1,
            "city_list": [
                {
                    "code": "CT_223",
                    "name": {
                        "zh_cn": "成都",
                        "en_us": "Chengdu"
                    }
                }
            ],
            "job_attribute": 1,
            "create_timestamp": "1617170925462",
            "update_timestamp": "1617170925462",
            "expiry_timestamp": "1622484739955",
            "target_major_list": [
                {
                    "id": "MDMJ00000067",
                    "zh_name": "考古",
                    "en_name": "archeology"
                }
            ]
        },
        "job_manager": {
            "id": "1618209327096",
            "recruiter_id": "ou_efk39117c300506837def50545420c6a",
            "hiring_manager_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ],
            "assistant_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ]
        },
        "interview_registration_schema_info": {
            "schema_id": "6930815272790114324",
            "name": "默认登记表"
        },
        "onboard_registration_schema_info": {
            "schema_id": "6930815272790114324",
            "name": "默认登记表"
        },
        "target_major_list": [
            {
                "id": "6930815272790114324",
                "zh_name": "考古",
                "en_name": "archeology"
            }
        ],
        "portal_website_apply_form_schema_info": {
            "schema_id": "6930815272790114324",
            "name": "默认申请表"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1JobsCombinedCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}