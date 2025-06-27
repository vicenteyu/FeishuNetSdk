// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobsByJobIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取职位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位信息 响应体
/// <para>接口ID：6963910685080289282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobsByJobIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job": {
            "id": "6001",
            "title": "测试职位",
            "description": "职位描述文本",
            "code": "R18",
            "requirement": "职位要求文本",
            "recruitment_type": {
                "id": "6001",
                "zh_name": "全职",
                "en_name": "FullTime",
                "active_status": 1
            },
            "department": {
                "id": "od-xxxx",
                "zh_name": "字节跳动",
                "en_name": "Bytedance"
            },
            "city": {
                "city_code": "C20",
                "zh_name": "成都",
                "en_name": "Chengdu"
            },
            "min_job_level": {
                "id": "6301",
                "zh_name": "级别-2",
                "en_name": "level-2",
                "active_status": 1
            },
            "max_job_level": {
                "id": "6301",
                "zh_name": "级别-2",
                "en_name": "level-2",
                "active_status": 1
            },
            "highlight_list": [
                {
                    "id": "6301",
                    "zh_name": "团队氛围好",
                    "en_name": "Positive team atmosphere"
                }
            ],
            "job_category": {
                "id": "6301",
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
            "create_user_id": "ou-xxx",
            "create_time": 1617170925462,
            "update_time": 1617170925462,
            "process_type": 1,
            "process_id": "1",
            "process_name": "流程中文名",
            "process_en_name": "流程英文名",
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
                            "start_time": "AA",
                            "end_time": "AA"
                        },
                        "time": "1625456721000",
                        "number": "111"
                    }
                }
            ],
            "job_function": {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                }
            },
            "subject": {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
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
                    "code": "1111",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                }
            ],
            "job_attribute": 1,
            "create_timestamp": "1617170925462",
            "update_timestamp": "1617170925462",
            "expiry_timestamp": "1622484739955",
            "target_major_list": [
                {
                    "id": "6930815272790114324",
                    "zh_name": "考古",
                    "en_name": "archeology"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobsByJobIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}