namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取内推官网下职位广告列表 响应体
/// <para>接口ID：7204730827112202244</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/referral/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_website-job_post%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ReferralWebsitesJobPostsResponseDto : TestBase
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
                "id": "7174316547413000195",
                "title": "高级工程师招聘",
                "job_id": "7392894182636030258",
                "job_code": "A168688",
                "job_expire_time": "1722837278000",
                "job_active_status": 1,
                "job_process_type": 1,
                "job_recruitment_type": {
                    "id": "101",
                    "name": {
                        "zh_cn": "全职",
                        "en_us": "Full-time"
                    }
                },
                "job_department": {
                    "id": "od-7b2eb7561bfbe4cac5267c142762870a",
                    "name": {
                        "zh_cn": "IT部门",
                        "en_us": "IT department"
                    }
                },
                "job_type": {
                    "id": "6791698585114724616",
                    "name": {
                        "zh_cn": "互联网 / 电子 / 网游",
                        "en_us": "Internet / Electronics / Games"
                    }
                },
                "min_job_level": {
                    "id": "6890840777044265230",
                    "name": {
                        "zh_cn": "级别-2",
                        "en_us": "level-2"
                    }
                },
                "max_job_level": {
                    "id": "6890840777044265230",
                    "name": {
                        "zh_cn": "级别-5",
                        "en_us": "level-5"
                    }
                },
                "address": {
                    "id": "7389174667692834820",
                    "name": {
                        "zh_cn": "抖音大厦",
                        "en_us": "Douyin Building"
                    },
                    "district": {
                        "code": "DS_1000002",
                        "name": {
                            "zh_cn": "大观区",
                            "en_us": "Daguan"
                        }
                    },
                    "city": {
                        "code": "CT_2",
                        "name": {
                            "zh_cn": "安庆",
                            "en_us": "Anqing"
                        }
                    },
                    "state": {
                        "code": "ST_2",
                        "name": {
                            "zh_cn": "安徽",
                            "en_us": "Anhui"
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
                "min_salary": "5",
                "max_salary": "50",
                "required_degree": 1,
                "experience": 1,
                "headcount": 12,
                "high_light_list": [
                    {
                        "id": "6732430418202593547",
                        "name": {
                            "zh_cn": "下午茶",
                            "en_us": "afternoon tea"
                        }
                    }
                ],
                "description": "负责软件开发",
                "requirement": "有相关经验者优先",
                "creator": {
                    "id": "ou_a512d829e05693f1cfaa419e17bd2d80",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "zhangsan"
                    }
                },
                "create_time": "1716791547691",
                "modify_time": "1716791547691",
                "customized_data_list": [
                    {
                        "object_id": "7368811146881091852",
                        "name": {
                            "zh_cn": "集团数字化",
                            "en_us": "group digitization"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "集团数字化是大方向",
                            "option": {
                                "key": "1",
                                "name": {
                                    "zh_cn": "支持",
                                    "en_us": "support"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "1",
                                    "name": {
                                        "zh_cn": "强支持",
                                        "en_us": "strong support"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1716791547691",
                                "end_time": "1716891547691"
                            },
                            "time": "1625456721000",
                            "number": "88"
                        }
                    }
                ],
                "job_function": {
                    "id": "7281257045172308287",
                    "name": {
                        "zh_cn": "技术",
                        "en_us": "technology"
                    }
                },
                "address_list": [
                    {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "抖音大厦",
                            "en_us": "Douyin Building"
                        },
                        "district": {
                            "code": "DS_1000002",
                            "name": {
                                "zh_cn": "大观区",
                                "en_us": "Daguan"
                            }
                        },
                        "city": {
                            "code": "CT_2",
                            "name": {
                                "zh_cn": "安庆",
                                "en_us": "Anqing"
                            }
                        },
                        "state": {
                            "code": "ST_2",
                            "name": {
                                "zh_cn": "安徽",
                                "en_us": "Anhui"
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
                ]
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ReferralWebsitesJobPostsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}