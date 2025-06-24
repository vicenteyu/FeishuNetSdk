// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取职位模板 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位模板 响应体
/// <para>接口ID：6989078472837251075</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_schema%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobSchemasResponseDto : TestBase
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
                    "zh_cn": "社招模板",
                    "en_us": "Social Job Template"
                },
                "scenario_type": 1,
                "object_list": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "基础信息",
                            "en_us": "Basic info"
                        },
                        "description": {
                            "zh_cn": "职位基础信息",
                            "en_us": "Job basic info"
                        },
                        "setting": {
                            "object_type": 1,
                            "config": {
                                "options": [
                                    {
                                        "key": "1",
                                        "name": {
                                            "zh_cn": "选项A",
                                            "en_us": "Option A"
                                        },
                                        "description": {
                                            "zh_cn": "选项A描述",
                                            "en_us": "Description of option A"
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
                                    "zh_cn": "职位类型",
                                    "en_us": "Job type"
                                },
                                "description": {
                                    "zh_cn": "职位类型描述",
                                    "en_us": "Job type description"
                                },
                                "setting": {
                                    "object_type": 1,
                                    "config": {
                                        "options": [
                                            {
                                                "key": "111",
                                                "name": {
                                                    "zh_cn": "类型A",
                                                    "en_us": "Type A"
                                                },
                                                "description": {
                                                    "zh_cn": "类型A的描述",
                                                    "en_us": "Description of type A"
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
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobSchemasResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}