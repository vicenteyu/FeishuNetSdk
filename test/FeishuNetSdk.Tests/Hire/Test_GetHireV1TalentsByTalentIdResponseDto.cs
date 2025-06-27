// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1TalentsByTalentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取人才信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才信息 响应体
/// <para>接口ID：6964264269274611714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentsByTalentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"ok",
"data":{"talent":{"id":"6891560630172518670",
"is_in_agency_period":true,
"is_onboarded":true,
"basic_info":{"name":"测试",
"mobile":"182900291190",
"mobile_code":"86",
"mobile_country_code":"CN_1",
"email":"16xx1@126.com",
"experience_years":5,
"age":22,
"nationality":{"nationality_code":"CN_183",
"zh_name":"测试",
"en_name":"test"},
"gender":1,
"current_city":{"city_code":"CN_183",
"zh_name":"测试",
"en_name":"test"},
"hometown_city":{"city_code":"CN_183",
"zh_name":"测试",
"en_name":"test"},
"preferred_city_list":[{
    "city_code": "CN_183",
    "zh_name": "测试",
    "en_name": "test"
}],
"identification_type":1,
"identification_number":"511699199x1x111234",
"birthday":1687872017,
"creator_id":"ou-xxx",
"marital_status":1,
"current_home_address":"南京路1号",
"customized_data_list":[{
    "object_id": "xxxx",
    "name": {
        "zh_cn": "测试",
        "en_us": "test"
    },
    "object_type": 1,
    "value": {
        "content": "text",
        "option": {
            "key": "AA",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            }
        },
        "option_list": [
            {
                "key": "AA",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
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
                "name": "1.13测试1的面试记录.pdf",
                "content_type": "application/pdf",
                "file_size": 16615
            }
        ]
    }
}],
"modify_time":"1634801678103",
"hukou_location_code":"CN_1"},
"education_list":[{"id":"6891560630172518670",
"degree":1,
"school":"湘港大学",
"field_of_study":"考古",
"start_time":"1990-01",
"end_time":"1994-01",
"end_time_v2":"1687180087000",
"education_type":1,
"academic_ranking":5,
"tag_list":[],
"customized_data_list":[{
    "object_id": "xxxx",
    "name": {
        "zh_cn": "测试",
        "en_us": "test"
    },
    "object_type": 1,
    "value": {
        "content": "text",
        "option": {
            "key": "AA",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            }
        },
        "option_list": [
            {
                "key": "AA",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
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
                "name": "1.13测试1的面试记录.pdf",
                "content_type": "application/pdf",
                "file_size": 16615
            }
        ]
    }
}]}],
"career_list":[{
    "id": "6891560630172518670",
    "company": "测试公司",
    "title": "高级工程师",
    "desc": "测试",
    "start_time": "1990-01",
    "end_time": "1994-01",
    "career_type": 1,
    "tag_list": [
        6
    ],
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"project_list":[{
    "id": "6891560630172518670",
    "name": "测试",
    "role": "test",
    "link": "www.test.com",
    "desc": "test",
    "start_time": "1990-01",
    "end_time": "1991-01",
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"works_list":[{
    "id": "6891560630172518670",
    "link": "www.test.com",
    "desc": "test",
    "name": "XX项目",
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"award_list":[{
    "id": "6891560630172518670",
    "title": "最佳新人奖",
    "award_time": "1991",
    "desc": "最优秀的新人奖",
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"language_list":[{
    "id": "6891560630172518670",
    "language": 1,
    "proficiency": 1,
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"sns_list":[{
    "id": "6891560630172518670",
    "sns_type": 1,
    "link": "www.test.com",
    "customized_data_list": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"resume_source_list":[{
    "id": "6891560630172518670",
    "zh_name": "猎头",
    "en_name": "Hunter"
}],
"interview_registration_list":[{
    "id": "6833685612520950030",
    "registration_time": 1618494330932,
    "download_url": "https://hire.feishu.cn/hire/file/blob/...token.../"
}],
"registration_list":[{
    "id": "6833685612520950030",
    "registration_time": 1618494330932,
    "download_url": "https://hire.feishu.cn/hire/file/blob/...token.../",
    "scenario": 5
}],
"resume_attachment_id_list":["64352523512563462"],
"customized_data_list":[{
    "object_id": "xxxx",
    "name": {
        "zh_cn": "测试",
        "en_us": "test"
    },
    "object_type": 1,
    "children": [
        {
            "object_id": "xxxx",
            "name": {
                "zh_cn": "测试",
                "en_us": "test"
            },
            "object_type": 1,
            "value": {
                "content": "text",
                "option": {
                    "key": "AA",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                },
                "option_list": [
                    {
                        "key": "AA",
                        "name": {
                            "zh_cn": "测试",
                            "en_us": "test"
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
                        "name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615
                    }
                ]
            }
        }
    ]
}],
"top_degree":1,
"first_degree":3}}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentsByTalentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}