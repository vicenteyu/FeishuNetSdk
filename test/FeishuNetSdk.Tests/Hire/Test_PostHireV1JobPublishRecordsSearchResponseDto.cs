// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobPublishRecordsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取职位广告发布记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位广告发布记录 响应体
/// <para>接口ID：7098526921116745729</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_publish_record%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobPublishRecordsSearchResponseDto : TestBase
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
                "id": "6791698585114724616",
                "title": "后端开发",
                "job_id": "6791698585114724616",
                "job_code": "A106043",
                "job_expire_time": "1722441599999",
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
                    "id": "6791698585114724616",
                    "name": {
                        "zh_cn": "程序研发中心",
                        "en_us": "程序研发中心"
                    }
                },
                "job_type": {
                    "id": "7396034232747346220",
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
                        "zh_cn": "中国大陆",
                        "en_us": "china"
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
                        "id": "7295577157198268716",
                        "name": {
                            "zh_cn": "高薪资",
                            "en_us": "high salary"
                        }
                    }
                ],
                "description": "负责软件开发",
                "requirement": "大专",
                "creator": {
                    "id": "7295577157198268716",
                    "name": {
                        "zh_cn": "孙晓静",
                        "en_us": "SunXiaojing"
                    }
                },
                "create_time": "1722024917416",
                "modify_time": "1722024917416",
                "customized_data_list": [
                    {
                        "object_id": "7396034232747346220",
                        "name": {
                            "zh_cn": "字段1",
                            "en_us": "field 1"
                        },
                        "object_type": 1,
                        "value": {
                            "content": "这是一个字段",
                            "option": {
                                "key": "7396034232747346220",
                                "name": {
                                    "zh_cn": "选择A",
                                    "en_us": "option A"
                                }
                            },
                            "option_list": [
                                {
                                    "key": "7396034232747346220",
                                    "name": {
                                        "zh_cn": "选项 A",
                                        "en_us": "option A"
                                    }
                                }
                            ],
                            "time_range": {
                                "start_time": "1722024917416",
                                "end_time": "1722024917416"
                            },
                            "time": "1625456721000",
                            "number": "2829"
                        }
                    }
                ],
                "address_list": [
                    {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "中国大陆",
                            "en_us": "China"
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
                ],
                "job_sequence_info": {
                    "id": "7395082456917805339",
                    "name": {
                        "zh_cn": "研发序列",
                        "en_us": "RD"
                    }
                },
                "currency": 1,
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1JobPublishRecordsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}