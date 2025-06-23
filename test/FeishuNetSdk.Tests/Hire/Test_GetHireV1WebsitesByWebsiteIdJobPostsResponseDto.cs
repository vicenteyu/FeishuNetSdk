namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘官网下的职位广告列表 响应体
/// <para>接口ID：6990661791098667011</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-job_post%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1WebsitesByWebsiteIdJobPostsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "id": "1213213123123",
                "title": "职位1",
                "job_id": "Job 1",
                "job_code": "007",
                "job_expire_time": "1111",
                "job_active_status": 1,
                "job_process_type": 1,
                "job_recruitment_type": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "全职",
                        "en_us": "Full-time"
                    }
                },
                "job_department": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "飞书",
                        "en_us": "Lark"
                    }
                },
                "job_type": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "金融",
                        "en_us": "Finance"
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
                        "zh_cn": "级别-2",
                        "en_us": "level-2"
                    }
                },
                "address": {
                    "id": "6583482347283472832",
                    "name": {
                        "zh_cn": "地址测试列表",
                        "en_us": "address test list"
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
                "min_salary": "5000",
                "max_salary": "10000",
                "required_degree": 1,
                "experience": 1,
                "headcount": 12,
                "high_light_list": [
                    {
                        "id": "1213213123123",
                        "name": {
                            "zh_cn": "高薪资",
                            "en_us": "high salary"
                        }
                    }
                ],
                "description": "负责软件开发",
                "requirement": "大专",
                "creator": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "孙晓静",
                        "en_us": "SunXiaojing"
                    }
                },
                "create_time": "1111",
                "modify_time": "222",
                "customized_data_list": [
                    {
                        "object_id": "xxxx",
                        "name": {
                            "zh_cn": "字段1",
                            "en_us": "field 1"
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
                "address_list": [
                    {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "地址列表",
                            "en_us": "address test list"
                        },
                        "district": {
                            "code": "1111",
                            "name": {
                                "zh_cn": "大观区",
                                "en_us": "Daguan"
                            }
                        },
                        "city": {
                            "code": "1111",
                            "name": {
                                "zh_cn": "安庆",
                                "en_us": "Anqing"
                            }
                        },
                        "state": {
                            "code": "1111",
                            "name": {
                                "zh_cn": "安徽",
                                "en_us": "Anhui"
                            }
                        },
                        "country": {
                            "code": "1111",
                            "name": {
                                "zh_cn": "中国大陆",
                                "en_us": "Chinese Mainland"
                            }
                        }
                    }
                ],
                "target_major_list": [
                    {
                        "id": "6930815272790114324",
                        "name": {
                            "zh_cn": "考古",
                            "en_us": "archeology"
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1WebsitesByWebsiteIdJobPostsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}