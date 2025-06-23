namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位详情 响应体
/// <para>接口ID：7397677441935884289</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/job/get_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fget_detail</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobsByJobIdGetDetailResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_detail": {
            "basic_info": {
                "id": "7395082456917805339",
                "title": "测试职位",
                "description": "这是一个测试职位，仅仅用来测试。",
                "code": "R18",
                "requirement": "职位要求文本",
                "recruitment_type": {
                    "id": "7395082456917805339",
                    "name": {
                        "zh_cn": "全职",
                        "en_us": "Full-time"
                    },
                    "active_status": 1
                },
                "department": {
                    "id": "7395082456917805339",
                    "name": {
                        "zh_cn": "飞书",
                        "en_us": "Lark"
                    }
                },
                "min_job_level": {
                    "id": "6890840777044265230",
                    "name": {
                        "zh_cn": "级别-2",
                        "en_us": "level-2"
                    },
                    "active_status": 1
                },
                "max_job_level": {
                    "id": "7395082456917805339",
                    "name": {
                        "zh_cn": "级别-2",
                        "en_us": "level-2"
                    },
                    "active_status": 1
                },
                "highlight_list": [
                    {
                        "id": "7395082456917805339",
                        "name": {
                            "zh_cn": "高薪资",
                            "en_us": "high salary"
                        }
                    }
                ],
                "job_category": {
                    "id": "7395082456917805339",
                    "name": {
                        "zh_cn": "研发序列",
                        "en_us": "RD"
                    },
                    "active_status": 1
                },
                "job_type": {
                    "id": "6890840777044265230",
                    "name": {
                        "zh_cn": "金融",
                        "en_us": "Finance"
                    }
                },
                "active_status": 1,
                "creator_id": "7395082456917805339",
                "create_time": "1617170925462",
                "update_time": "1617170925462",
                "process_type": 1,
                "process_id": "1",
                "process_name": {
                    "zh_cn": "社招流程",
                    "en_us": "Social process"
                },
                "customized_data_list": [
                    {
                        "object_id": "6949805467799537964",
                        "name": {
                            "zh_cn": "集团化",
                            "en_us": "JiTuanHua"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "集团化使用字段",
                            "option": {
                                "key": "AA",
                                "name": {
                                    "zh_cn": "选项A",
                                    "en_us": "选项A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "AA",
                                    "name": {
                                        "zh_cn": "多选A",
                                        "en_us": "多选A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1721976368000",
                                "end_time": "1721976368000"
                            },
                            "time": "1625456721000",
                            "number": "111"
                        }
                    }
                ],
                "job_function": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "分类1",
                        "en_us": "function 1"
                    }
                },
                "subject": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "测试项目",
                        "en_us": "Test subject"
                    }
                },
                "head_count": 100,
                "experience": 1,
                "expiry_time": "1622484739955",
                "min_salary": 10,
                "max_salary": 20,
                "required_degree": 1,
                "city_list": [
                    {
                        "code": "CT_112",
                        "name": {
                            "zh_cn": "上海市",
                            "en_us": "ShangHai"
                        }
                    }
                ],
                "job_attribute": 1,
                "target_major_list": [
                    {
                        "id": "6930815272790114324",
                        "name": {
                            "zh_cn": "社会学",
                            "en_us": "Social"
                        }
                    }
                ],
                "storefront_mode": 1
            },
            "recruiter": {
                "id": "ou_efk39117c300506837def50545420c6a",
                "name": {
                    "zh_cn": "张三",
                    "en_us": "ZhangSan"
                }
            },
            "assistant_list": [
                {
                    "id": "ou_efk39117c300506837def50545420c6a",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "ZhangSan"
                    }
                }
            ],
            "hiring_manager_list": [
                {
                    "id": "ou_efk39117c300506837def50545420c6a",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "ZhangSan"
                    }
                }
            ],
            "job_requirement_list": [
                {
                    "id": "6949805467799537964",
                    "short_code": "2232",
                    "name": "华中大区部门",
                    "department_id": "6833685612520950030"
                }
            ],
            "address_list": [
                {
                    "id": "6583482347283472832",
                    "name": {
                        "zh_cn": "北京华清大厦3324号",
                        "en_us": "No. 3324, Huaqing Building, Beijing"
                    },
                    "district": {
                        "code": "DS_70",
                        "name": {
                            "zh_cn": "铁东区",
                            "en_us": "Tiedong"
                        }
                    },
                    "city": {
                        "code": "CT_1",
                        "name": {
                            "zh_cn": "鞍山",
                            "en_us": "Anshan"
                        }
                    },
                    "state": {
                        "code": "ST_1",
                        "name": {
                            "zh_cn": "ST_1",
                            "en_us": "Liaoning"
                        }
                    },
                    "country": {
                        "code": "CN_1",
                        "name": {
                            "zh_cn": "中国大陆",
                            "en_us": "Chinese Mainland"
                        }
                    }
                }
            ],
            "job_config": {
                "offer_apply_schema": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "申请表1",
                        "en_us": "Offer Apply 1"
                    }
                },
                "offer_process_conf": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "审批流程1",
                        "en_us": "Test Process 1"
                    }
                },
                "recommended_evaluator_list": [
                    {
                        "id": "7392444731470563625",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "ZhangSan"
                        }
                    }
                ],
                "assessment_template": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "评价表1",
                        "en_us": "assessment_template·1"
                    }
                },
                "interview_round_list": [
                    {
                        "interviewer_list": [
                            {
                                "id": "7392444731470563625",
                                "name": {
                                    "zh_cn": "张三",
                                    "en_us": "ZhangSan"
                                }
                            }
                        ],
                        "round": 1
                    }
                ],
                "interview_registration": {
                    "schema_id": "6930815272790114324",
                    "name": "默认登记表"
                },
                "onboard_registration": {
                    "schema_id": "6930815272790114324",
                    "name": "默认登记表"
                },
                "interview_round_type_list": [
                    {
                        "assessment_round": {
                            "id": "7392444731470563625",
                            "name": {
                                "zh_cn": "测试类型",
                                "en_us": "Test type"
                            }
                        },
                        "assessment_template": {
                            "id": "7392444731470563625",
                            "name": {
                                "zh_cn": "测试评级表",
                                "en_us": "Test Name"
                            }
                        }
                    }
                ],
                "related_job_list": [
                    {
                        "id": "7392444731470563625",
                        "name": {
                            "zh_cn": "职位1",
                            "en_us": "job1"
                        }
                    }
                ],
                "job_attribute": 1,
                "interview_appointment_config": {
                    "enable_interview_appointment_by_interviewer": true,
                    "config": {
                        "interview_type": 1,
                        "talent_timezone_code": "Asia/Shanghai",
                        "contact_user_id": "ou_c99c5f35d542efc7ee492afe11af19ef",
                        "contact_mobile": "177xxxx1773",
                        "contact_email": "test@open.com",
                        "address_id": "6960663240925956576",
                        "video_type": 1,
                        "cc": [
                            "ou_c99c5f35d542efc7ee492afe11af19ef"
                        ],
                        "remark": "这个职位最好选择现场牛客网面试",
                        "interview_notification_template_id": "6960663240925956573",
                        "appointment_notification_template_id": "6960663240925956573",
                        "cancel_interview_notification_template_id": "6960663240925956573"
                    }
                },
                "internship_offer_apply_schema": {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "第一个申请表",
                        "en_us": "The first apply form"
                    }
                }
            },
            "storefront_list": [
                {
                    "id": "6960663240925956547",
                    "name": {
                        "zh_cn": "肯德基门店",
                        "en_us": "KFC Store"
                    },
                    "active_status": 1,
                    "department": {
                        "id": "7392444731470563625",
                        "name": {
                            "zh_cn": "华北大区部门",
                            "en_us": "Hua Bei Department"
                        }
                    },
                    "address": {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "北京华清大厦2226号",
                            "en_us": "No. 2226, Huaqing Building, Beijing"
                        },
                        "district": {
                            "code": "DS_70",
                            "name": {
                                "zh_cn": "铁东区",
                                "en_us": "Tiedong"
                            }
                        },
                        "city": {
                            "code": "CT_1",
                            "name": {
                                "zh_cn": "鞍山",
                                "en_us": "Anshan"
                            }
                        },
                        "state": {
                            "code": "ST_1",
                            "name": {
                                "zh_cn": "辽宁",
                                "en_us": "Liaoning"
                            }
                        },
                        "country": {
                            "code": "CN_1",
                            "name": {
                                "zh_cn": "中国大陆",
                                "en_us": "Chinese Mainland"
                            }
                        }
                    },
                    "manager": {
                        "id": "ou_efk39117c300506837def50545420c6a",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "ZhangSan"
                        }
                    },
                    "create_time": "1622484739955",
                    "remark": {
                        "zh_cn": "这是一个备注.....",
                        "en_us": "This is note"
                    }
                }
            ],
            "tag_list": [
                {
                    "id": "6949805467799537964",
                    "name": {
                        "zh_cn": "985、211",
                        "en_us": "985、211"
                    },
                    "order": 1
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobsByJobIdGetDetailResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}