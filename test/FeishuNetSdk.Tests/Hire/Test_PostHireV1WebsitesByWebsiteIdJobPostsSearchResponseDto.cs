// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1WebsitesByWebsiteIdJobPostsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索招聘官网下的职位广告列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 搜索招聘官网下的职位广告列表 响应体
/// <para>接口ID：7021042393814450179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-job_post%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdJobPostsSearchResponseDto : TestBase
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
                "id": "7392894182636144946",
                "title": "职位1",
                "job_id": "7380246392272603428",
                "job_code": "007",
                "job_expire_time": "1111",
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
                    "id": "6793124489011103245",
                    "name": {
                        "zh_cn": "产品部",
                        "en_us": "product department"
                    }
                },
                "job_type": {
                    "id": "6930815272790114324",
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
                        "zh_cn": "安庆",
                        "en_us": "Anqing"
                    },
                    "district": {
                        "code": "MDCA00009061",
                        "name": {
                            "zh_cn": "大观区",
                            "en_us": "Daguan"
                        }
                    },
                    "city": {
                        "code": "CT_22",
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
                },
                "min_salary": "5",
                "max_salary": "10",
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
                "requirement": "大专",
                "creator": {
                    "id": "ou_e2fc714c4727ee9395f324cd2e7f331f",
                    "name": {
                        "zh_cn": "袁一一",
                        "en_us": "Yiyi Yuan"
                    }
                },
                "create_time": "1715867075246",
                "modify_time": "1715867075246",
                "customized_data_list": [
                    {
                        "object_id": "6949805467799537964",
                        "name": {
                            "zh_cn": "集团化",
                            "en_us": "collectivize"
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
                "job_function": {
                    "id": "7010952553315895596",
                    "name": {
                        "zh_cn": "研发",
                        "en_us": "RD"
                    }
                },
                "subject": {
                    "id": "7368380000360401188",
                    "name": {
                        "zh_cn": "项目1",
                        "en_us": "project 1"
                    }
                },
                "address_list": [
                    {
                        "id": "6583482347283472832",
                        "name": {
                            "zh_cn": "成都抖音集团大厦",
                            "en_us": "Chengdu Douyin Group Building"
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdJobPostsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}