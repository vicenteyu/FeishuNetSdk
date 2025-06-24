// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1TalentObjectsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取人才字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才字段 响应体
/// <para>接口ID：6989078472837185539</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_object%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentObjectsQueryResponseDto : TestBase
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
                "id": "6949805467799537964",
                "name": {
                    "zh_cn": "教育经历",
                    "en_us": "Education"
                },
                "description": {
                    "zh_cn": "人才的教育经历信息",
                    "en_us": "The education infos of talent"
                },
                "setting": {
                    "object_type": 11,
                    "config": {
                        "options": [
                            {
                                "key": "1",
                                "name": {
                                    "zh_cn": "选项一",
                                    "en_us": "Option 1"
                                },
                                "description": {
                                    "zh_cn": "这是第一个选项",
                                    "en_us": "This is the option 1"
                                },
                                "active_status": 1
                            }
                        ]
                    }
                },
                "is_customized": true,
                "is_required": false,
                "active_status": 1,
                "children_list": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "学历",
                            "en_us": "Degree"
                        },
                        "description": {
                            "zh_cn": "人才的学历是什么",
                            "en_us": "What is the degree of talent"
                        },
                        "setting": {
                            "object_type": 3,
                            "config": {
                                "options": [
                                    {
                                        "key": "1",
                                        "name": {
                                            "zh_cn": "选项一",
                                            "en_us": "Option 1"
                                        },
                                        "description": {
                                            "zh_cn": "这是第一个选项",
                                            "en_us": "This is option 1"
                                        },
                                        "active_status": 1
                                    }
                                ]
                            }
                        },
                        "parent_id": "6949805467799537964",
                        "is_customized": true,
                        "is_required": false,
                        "active_status": 1
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentObjectsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}