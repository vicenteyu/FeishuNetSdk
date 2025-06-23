namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取投递详情 响应体
/// <para>接口ID：7397703144758165532</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/application/get_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fget_detail</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ApplicationsByApplicationIdGetDetailResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "application_detail": {
            "basic_info": {
                "id": "6949805467799537964",
                "job_id": "6843547872837273223",
                "talent_id": "6843547872837273223",
                "stage": {
                    "id": "614218419274131",
                    "zh_name": "面试",
                    "en_name": "Interview",
                    "type": 1
                },
                "active_status": 1,
                "delivery_type": 1,
                "resume_source_info": {
                    "id": "614218419274131",
                    "name": {
                        "zh_cn": "内推",
                        "en_us": "Referral"
                    },
                    "resume_source_type": 10002
                },
                "website_resume_source": {
                    "website_id": "614218419274131",
                    "website_name": {
                        "zh_cn": "新希望官网",
                        "en_us": "New hope offical"
                    },
                    "channel": {
                        "channel_id": "777218419274131",
                        "channel_name": {
                            "zh_cn": "领英",
                            "en_us": "LinkedIn"
                        }
                    }
                },
                "talent_attachment_resume_id": "6960663240925956415",
                "stage_time_list": [
                    {
                        "stage_id": "614218419274131",
                        "enter_time": "1632991542615",
                        "exit_time": "1631509574398"
                    }
                ],
                "onboard_status": 1,
                "application_preferred_city_list": [
                    {
                        "code": "CT _1",
                        "name": {
                            "zh_cn": "北京",
                            "en_us": "Beijing"
                        }
                    }
                ],
                "termination_reason": {
                    "id": "6891258038901016846",
                    "name": {
                        "zh_cn": "候选人拒绝",
                        "en_us": "Candidate rejected"
                    },
                    "children": [
                        {
                            "id": "6891258038901016846",
                            "name": {
                                "zh_cn": "对公司业务不感兴趣",
                                "en_us": "Not interested in company business"
                            }
                        }
                    ]
                },
                "creator_id": "ou_ce613028fe74745421f5dc320bb9c709",
                "owner_id": "ou_ce913028fe74123221f5dc320bb9c709",
                "terminator_id": "ou_ce913028fe74123221f5dc320bb9c709",
                "create_time": "1632990774278",
                "modify_time": "1634801678103"
            },
            "job": {
                "id": "6956499586395523359",
                "name": "后端研发工程师",
                "code": "A75256"
            },
            "talent": {
                "id": "6956499586395523359",
                "name": "小明",
                "mobile_code": "+86",
                "mobile_number": "13563350751",
                "email": "xxx@bytedance.com"
            },
            "evaluations": [
                {
                    "id": "6875295756292425998",
                    "application_id": "6875569957036738823",
                    "stage_id": "6784315427607595268",
                    "creator_id": "ou_aaf83d1b2c856ead36aa9a38784b9a5c",
                    "evaluator_id": "ou_aaf83d1b2c856ead36aa9a38784b9a5c",
                    "commit_status": 1,
                    "conclusion": 1,
                    "content": "这位同学很优秀",
                    "create_time": "1600843767338",
                    "update_time": "1600843937733"
                }
            ],
            "interview_aggregation": {
                "interviews": [
                    {
                        "id": "6949805467799537964",
                        "begin_time": "1618899376474",
                        "end_time": "1618999376474",
                        "round": 0,
                        "interview_record_list": [
                            {
                                "id": "7171693733661327361",
                                "feedback_form_id": "71716937336613273612",
                                "commit_status": 1,
                                "submit_time": "1710405457390",
                                "record_score": {
                                    "score": 85.33,
                                    "total_score": 100
                                },
                                "interviewer": {
                                    "id": "6956499586395523359",
                                    "name": {
                                        "zh_cn": "张三",
                                        "en_us": "Tom cruise"
                                    }
                                },
                                "attachments": [
                                    {
                                        "file_id": "7140517838785481004",
                                        "file_name": "1.13测试1的面试记录.pdf",
                                        "content_type": "application/pdf",
                                        "create_time": "1710399930151"
                                    }
                                ],
                                "module_assessments": [
                                    {
                                        "interview_feedback_form_module_id": "7171693733661327361",
                                        "module_name": {
                                            "zh_cn": "模块一",
                                            "en_us": "Module 1"
                                        },
                                        "module_type": 1,
                                        "module_weight": 10,
                                        "module_score": 10,
                                        "dimension_assessments": [
                                            {
                                                "interview_feedback_form_dimension_id": "7171693733661327361",
                                                "dimension_name": {
                                                    "zh_cn": "维度一",
                                                    "en_us": "Dimension 1"
                                                },
                                                "dimension_type": 1,
                                                "weight": 1,
                                                "dimension_content": "描述题作答",
                                                "dimension_option": {
                                                    "id": "7171693733661327361",
                                                    "name": {
                                                        "zh_cn": "选项一",
                                                        "en_us": "Option 1"
                                                    },
                                                    "score_val": 10
                                                },
                                                "dimension_options": [
                                                    {
                                                        "id": "7171693733661327361",
                                                        "name": {
                                                            "zh_cn": "选项一",
                                                            "en_us": "Option 1"
                                                        },
                                                        "score_val": 10
                                                    }
                                                ],
                                                "dimension_score": 10,
                                                "recommended_job_level": {
                                                    "lower_limit_job_level_name": {
                                                        "zh_cn": "多元化、跨国企业，最低职级建议为 6 - 10 级",
                                                        "en_us": "Diversified, multinational companies, the minimum recommended job level is 6 - 10"
                                                    },
                                                    "higher_limit_job_level_name": {
                                                        "zh_cn": "多元化、跨国企业，最高职级建议为 12 - 14 级",
                                                        "en_us": "Diversified, multinational companies, the maximum recommended job level is 12 - 14"
                                                    }
                                                },
                                                "question_assessments": [
                                                    {
                                                        "question_type": 1,
                                                        "title": {
                                                            "zh_cn": "题目一",
                                                            "en_us": "Question 1"
                                                        },
                                                        "description": {
                                                            "zh_cn": "这是一段对面试题的中文描述",
                                                            "en_us": "This is a description of question 1."
                                                        },
                                                        "content": "我对这道题目的作答是...",
                                                        "abilities": [
                                                            {
                                                                "id": "7270798542321666366",
                                                                "name": {
                                                                    "zh_cn": "创新思维",
                                                                    "en_us": "Creative Thinking"
                                                                },
                                                                "description": {
                                                                    "zh_cn": "创新思维",
                                                                    "en_us": "Creative Thinking"
                                                                }
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            }
                        ],
                        "feedback_submit_time": "1659318415000",
                        "stage_id": "634324253532232",
                        "application_id": "634324253532232",
                        "stage": {
                            "id": "1213213123123",
                            "name": {
                                "zh_cn": "阶段一",
                                "en_us": "Stage 1"
                            }
                        },
                        "creator": {
                            "id": "1213213123123",
                            "name": {
                                "zh_cn": "张三",
                                "en_us": "Bob"
                            }
                        },
                        "create_time": "1618999376474",
                        "update_time": "1618999376474",
                        "interview_round_summary": 2,
                        "interview_arrangement_id": "6888110869563033870",
                        "interview_type": 1,
                        "talent_time_zone": {
                            "code": "Asia/Shanghai",
                            "name": {
                                "zh_cn": "上海",
                                "en_us": "Shanghai"
                            }
                        },
                        "contact_user": {
                            "id": "1213213123123",
                            "name": {
                                "zh_cn": "王五",
                                "en_us": "Alice"
                            }
                        },
                        "contact_mobile": "13333333333",
                        "remark": "这是一条备注",
                        "address": {
                            "id": "6583482347283472832",
                            "name": {
                                "zh_cn": "北京",
                                "en_us": "Beijing"
                            },
                            "district": {
                                "name": {
                                    "zh_cn": "朝阳区",
                                    "en_us": "Chaoyang District"
                                },
                                "code": "400700",
                                "location_type": 1
                            },
                            "city": {
                                "name": {
                                    "zh_cn": "上海",
                                    "en_us": "Shanghai"
                                },
                                "code": "400700",
                                "location_type": 1
                            },
                            "state": {
                                "name": {
                                    "zh_cn": "湖南省",
                                    "en_us": "Hunan  Province"
                                },
                                "code": "400700",
                                "location_type": 1
                            },
                            "country": {
                                "name": {
                                    "zh_cn": "中国",
                                    "en_us": "China"
                                },
                                "code": "400700",
                                "location_type": 1
                            }
                        },
                        "video_type": 1,
                        "arrangement_status": 1,
                        "arrangement_type": 1,
                        "arrangement_appointment_kind": 1,
                        "meeting_room_list": [
                            {
                                "room_id": "6949805467799537964",
                                "room_name": "OCG111",
                                "building_name": "OCG",
                                "reserved_status": 1,
                                "floor_name": "17"
                            }
                        ],
                        "interview_round_type": {
                            "id": "1213213123123",
                            "name": {
                                "zh_cn": "第一轮",
                                "en_us": "First round"
                            }
                        }
                    }
                ]
            },
            "offer": {
                "offer_basic": {
                    "id": "7056641315456469292",
                    "offer_status": 10,
                    "leader": {
                        "id": "6956499586395523359",
                        "name": {
                            "zh_cn": "张三",
                            "en_us": "Bob"
                        }
                    },
                    "employee_type": {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "正式",
                            "en_us": "Regular"
                        }
                    },
                    "department": {
                        "id": "6956499586395523359",
                        "name": {
                            "zh_cn": "HR 部门",
                            "en_us": "HR Department"
                        }
                    },
                    "sequence": {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "研发",
                            "en_us": "RD"
                        }
                    },
                    "level": {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "3-1",
                            "en_us": "3-1"
                        }
                    },
                    "company_main_body": {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "顶呱呱公司",
                            "en_us": "Dingguagua"
                        }
                    },
                    "job_requirement_id": "7018398769038182700",
                    "probation_month": 3,
                    "contract_period": {
                        "period_type": 1,
                        "period": 3
                    },
                    "onboard_date": "2023-01-01",
                    "owner": {
                        "id": "6956499586395523359",
                        "name": {
                            "zh_cn": "赵六",
                            "en_us": "Tom"
                        }
                    },
                    "onboard_address": {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "成都市高新区天府四街",
                            "en_us": "Tianfu 4th street, Gaoxin district, Chengdu"
                        },
                        "district": {
                            "name": {
                                "zh_cn": "高新区",
                                "en_us": "Gaoxin"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "city": {
                            "name": {
                                "zh_cn": "成都",
                                "en_us": "Chengdu"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "state": {
                            "name": {
                                "zh_cn": "四川",
                                "en_us": "Sichuan"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "country": {
                            "name": {
                                "zh_cn": "中国",
                                "en_us": "China"
                            },
                            "code": "400700",
                            "location_type": 1
                        }
                    },
                    "work_address": {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "成都市高新区天府四街",
                            "en_us": "Tianfu 4th street, Gaoxin district, Chengdu"
                        },
                        "district": {
                            "name": {
                                "zh_cn": "高新",
                                "en_us": "Gaoxin"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "city": {
                            "name": {
                                "zh_cn": "成都",
                                "en_us": "Chengdu"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "state": {
                            "name": {
                                "zh_cn": "四川",
                                "en_us": "Sichuan"
                            },
                            "code": "400700",
                            "location_type": 1
                        },
                        "country": {
                            "name": {
                                "zh_cn": "中国",
                                "en_us": "China"
                            },
                            "code": "400700",
                            "location_type": 1
                        }
                    },
                    "remark": "这个 Offer 需要加急审批",
                    "attachment_list": [
                        {
                            "id": "7018398769038182700",
                            "name": "获奖证书「全套」",
                            "size": 4096,
                            "common_attachment_id": "7118398769038182701"
                        }
                    ],
                    "customize_info_list": [
                        {
                            "object_id": "6930815272790114324",
                            "customize_value": "This is a text type customized data value"
                        }
                    ],
                    "create_time": "1619719298000"
                },
                "offer_salary": {
                    "id": "6956641395189795116",
                    "salary_status": 1,
                    "probation_salary_percentage": "30%",
                    "award_salary_multiple": "3",
                    "option_shares": "100",
                    "quarterly_bonus": "1000",
                    "half_year_bonus": "3000",
                    "total_annual_cash": "200000",
                    "customize_info_list": [
                        {
                            "object_id": "6930815272790114324",
                            "customize_value": "1"
                        }
                    ],
                    "create_time": "1619720918463"
                }
            },
            "employee": {
                "id": "123",
                "application_id": "6990656563279480364",
                "onboard_status": 1,
                "conversion_status": 1,
                "onboard_time": "1637596800000",
                "expected_conversion_time": "1637596800000",
                "actual_conversion_time": "1637596800000",
                "overboard_time": "1637596800000",
                "overboard_note": "职业发展考虑",
                "onboard_city_code": "C20",
                "department_id": "6966123381141866028",
                "leader_id": "ou-xxx",
                "sequence_id": "6501",
                "level_id": "6301",
                "employee_type": "1",
                "job_requirement_id": "123123123213"
            },
            "agency": {
                "basic_info": {
                    "hunter_user_name": {
                        "zh_cn": "猎头一号",
                        "en_us": "Hunter One"
                    },
                    "hunter_company_name": "明天会更好猎头公司"
                },
                "comment_info": [
                    {
                        "name": {
                            "zh_cn": "能力",
                            "en_us": "Ability"
                        },
                        "value": {
                            "zh_cn": "还不错",
                            "en_us": "Not bad"
                        },
                        "description": {
                            "zh_cn": "这是一段中文的猎头评价信息描述",
                            "en_us": "This is a english comment of comment info"
                        }
                    }
                ],
                "salary_info": [
                    {
                        "name": {
                            "zh_cn": "当前薪资",
                            "en_us": "Current salary"
                        },
                        "value": {
                            "zh_cn": "5000",
                            "en_us": "5000"
                        },
                        "description": {
                            "zh_cn": "这是一段测试描述",
                            "en_us": "This is a test description"
                        }
                    }
                ]
            },
            "portal": {
                "campus_volunteer_info": {
                    "volunteer_seq": 1
                }
            },
            "referral": {
                "basic_info": {
                    "id": "6956498101012220204",
                    "application_id": "7051498101012220201",
                    "referral_type": 1,
                    "user_info": {
                        "id": "6956499586395523359",
                        "name": {
                            "zh_cn": "赵六",
                            "en_us": "Tom"
                        }
                    },
                    "create_time": "1619720918791",
                    "referral_method": 1
                },
                "recommend_info": {
                    "relationship": 1,
                    "familiarity": 0,
                    "comment": "该同学十分优秀，经验丰富。",
                    "specific_relationship": {
                        "relation_with_candidate": 1,
                        "extra": "在前公司合作非常愉快～"
                    },
                    "work_ability_familiarity": 1,
                    "match_degree": 1
                }
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ApplicationsByApplicationIdGetDetailResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}