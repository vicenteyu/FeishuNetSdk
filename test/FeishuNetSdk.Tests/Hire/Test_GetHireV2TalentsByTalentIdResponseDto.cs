namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才详情 响应体
/// <para>接口ID：7177216475677474820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhire-v2%2ftalent%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV2TalentsByTalentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "talent_id": "6761694410053798151",
        "basic_info": {
            "name": "张三",
            "mobile_number": "18312341234",
            "mobile_code": "86",
            "email": "16xx1@126.com",
            "experience_years": 5,
            "age": 22,
            "nationality_code": "CN",
            "gender": 1,
            "current_location_code": "CN_2",
            "hometown_location_code": "CN_3",
            "preferred_location_code_list": [
                "CN_2"
            ],
            "home_address": "北京朝阳区",
            "identification_type": 1,
            "identification_number": "511699199x1x111234",
            "birthday": 293016767159,
            "marital_status": 1,
            "customized_data_list": [
                {
                    "object_id": "7392444731470547241",
                    "name": {
                        "zh_cn": "字段1",
                        "en_us": "field 1"
                    },
                    "object_type": 1,
                    "value": {
                        "content": "text",
                        "option": {
                            "key": "7350282123172432169",
                            "name": {
                                "zh_cn": "选项1",
                                "en_us": "option 1"
                            }
                        },
                        "option_list": [
                            {
                                "key": "7350282123172432169",
                                "name": {
                                    "zh_cn": "多选1",
                                    "en_us": "multi option1"
                                }
                            }
                        ],
                        "time_range": {
                            "start_time": "1625456721",
                            "end_time": "1625656721"
                        },
                        "time": "1625456721",
                        "number": "111",
                        "customized_attachment": [
                            {
                                "file_id": "7140517838785481004",
                                "file_name": "1.13测试1的面试记录.pdf",
                                "content_type": "application/pdf",
                                "file_size": 16615
                            }
                        ]
                    }
                }
            ],
            "hukou_location_code": "CN_1",
            "update_time": "1634801678103",
            "create_time": "1634801678103",
            "confidential": 1
        },
        "education_list": [
            {
                "degree": 1,
                "school_name": "湘港大学",
                "major": "考古",
                "start_time": "1992-01",
                "end_time": "1994-01",
                "education_type": 1,
                "academic_ranking": 5,
                "customized_data_list": [
                    {
                        "object_id": "7392444731470563625",
                        "name": {
                            "zh_cn": "人才过往",
                            "en_us": "talent old history"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个自定义字段内容",
                            "option": {
                                "key": "7392444731470563625",
                                "name": {
                                    "zh_cn": "选项A",
                                    "en_us": "test"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7392444731470563625",
                                    "name": {
                                        "zh_cn": "选项A",
                                        "en_us": "Option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "career_list": [
            {
                "company_name": "明日科技公司",
                "description": "明日科技",
                "end_time": "2023-06",
                "start_time": "2023-06",
                "title": "高级工程师",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "经历地址",
                            "en_us": "data english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "project_list": [
            {
                "project_name": "权限重构项目",
                "role": "项目负责人",
                "link": "www.recruitment-demo.com",
                "description": "招聘网站",
                "start_time": "1990-01",
                "end_time": "1991-01",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "自定义字段",
                            "en_us": "english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "Option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "works_list": [
            {
                "id": "6891560630172518670",
                "link": "https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2",
                "description": "人才信息页面",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "字段1",
                            "en_us": "english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "award_list": [
            {
                "award_name": "最佳新人奖",
                "award_time": "1992-01",
                "description": "最优秀的新人奖",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "字段1",
                            "en_us": "english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "language_list": [
            {
                "language": 1,
                "proficiency": 1,
                "customized_data_list": [
                    {
                        "object_id": "6792436415209817608",
                        "name": {
                            "zh_cn": "字段 1",
                            "en_us": "english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "sns_list": [
            {
                "sns_type": 1,
                "link": "1",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "字段 1",
                            "en_us": "option A"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "Option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "resume_source_list": [
            {
                "id": "6891560630172518670",
                "zh_name": "猎头",
                "en_name": "Hunter"
            }
        ],
        "internship_list": [
            {
                "company_name": "明日科技",
                "description": "明日科技实习公司",
                "end_time": "1992-01",
                "start_time": "1992-01",
                "title": "实习科学家",
                "customized_data_list": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "字段 1",
                            "en_us": "test"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "customized_data_list": [
            {
                "module_id": "7106698109352479020",
                "name": {
                    "zh_cn": "模块 1",
                    "en_us": "module 1"
                },
                "object_type": 1,
                "children": [
                    {
                        "object_id": "7395082456917641499",
                        "name": {
                            "zh_cn": "字段 1",
                            "en_us": "english name"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个单行文本",
                            "option": {
                                "key": "7395082456917641499",
                                "name": {
                                    "zh_cn": "选项 A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7395082456917641499",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "english name"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1625456721",
                                "end_time": "1625656721"
                            },
                            "time": "1625456721",
                            "number": "111",
                            "customized_attachment": [
                                {
                                    "file_id": "7140517838785481004",
                                    "file_name": "1.13测试1的面试记录.pdf",
                                    "content_type": "application/pdf",
                                    "file_size": 16615
                                }
                            ]
                        }
                    }
                ]
            }
        ],
        "resume_attachment_id_list": [
            "64352523512563462"
        ],
        "resume_attachment_list": [
            {
                "id": "6891560630172518670",
                "name": "1.pdf",
                "mime": "application/pdf",
                "create_time": "1734348840749"
            }
        ],
        "interview_registration_list": [
            {
                "id": "6833685612520950030",
                "registration_time": 1618494330932,
                "download_url": "https://hire.feishu.cn/hire/file/blob/...token.../"
            }
        ],
        "registration_list": [
            {
                "id": "6833685612520950030",
                "registration_time": 1618494330932,
                "download_url": "https://hire.feishu.cn/hire/file/blob/...token.../",
                "scenario": 5
            }
        ],
        "is_onboarded": true,
        "is_in_agency_period": true,
        "top_degree": 1,
        "talent_pool_id_list": [
            "7171693733661327361"
        ],
        "talent_folder_ref_list_v2": [
            {
                "name": "人才文件夹A1",
                "folder_id": "7041806543797995820",
                "owner_id": "ou_85bb308c57f597471cd2bb5b4f580245",
                "add_time": "1634801678103"
            }
        ],
        "tag_list": [
            {
                "id": "7140517838785481004",
                "name": {
                    "zh_cn": "高学历人才",
                    "en_us": "985"
                },
                "description": {
                    "zh_cn": "这是一个标签",
                    "en_us": "this is a english tag"
                },
                "type": 1
            }
        ],
        "similar_info_v2": {
            "is_similar_talent": true,
            "similar_talent_id_list": [
                "6891560630172518670"
            ]
        },
        "block_info": {
            "blocked_time": "1625656721",
            "creator_id": "6891560630172518670",
            "reason": "人才作弊"
        },
        "talent_pool_ref_list_v2": [
            {
                "id": "6891560630172518670",
                "name": {
                    "zh_cn": "测试人才库",
                    "en_us": "Test talent pool"
                },
                "description": {
                    "zh_cn": "这是一个测试人才库",
                    "en_us": "This is a test talent pool"
                },
                "add_time": "1634801678103"
            }
        ],
        "note_list_v2": [
            {
                "id": "6949805467799537964",
                "talent_id": "6916472453069883661",
                "application_id": "6891565253964859661",
                "create_time": "1618209327096",
                "update_time": "1618209327096",
                "creator_id": "ou_f476cb099ac9227c9bae09ce46112579",
                "content": "测试备注内容",
                "privacy": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV2TalentsByTalentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}