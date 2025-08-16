// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-16
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="Test_GetHireV1PortalApplySchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取申请表模板列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取申请表模板列表 响应体
/// <para>接口ID：7451965544983871516</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/portal_apply_schema/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fportal_apply_schema%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1PortalApplySchemasResponseDto : TestBase
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
                "id": "7044739584859326764",
                "name": "默认官网申请表",
                "scenarios": [
                    14
                ],
                "objects": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "基本信息",
                            "en_us": "Basic Information"
                        },
                        "description": {
                            "zh_cn": "候选人的基本信息",
                            "en_us": "The basic information of the candidate"
                        },
                        "setting": {
                            "object_type": 1,
                            "config": {
                                "options": [
                                    {
                                        "key": "Option1",
                                        "name": {
                                            "zh_cn": "选项一",
                                            "en_us": "Option1"
                                        },
                                        "description": {
                                            "zh_cn": "第一个选项",
                                            "en_us": "First Option"
                                        },
                                        "active_status": 1
                                    }
                                ]
                            }
                        },
                        "is_customized": true,
                        "is_required": false,
                        "is_visible": true,
                        "active_status": 1,
                        "children_list": [
                            {
                                "id": "6949805467799537964",
                                "name": {
                                    "zh_cn": "自定义字段",
                                    "en_us": "Custom Field"
                                },
                                "description": {
                                    "zh_cn": "第一个自定义字段",
                                    "en_us": "First Custom Field"
                                },
                                "setting": {
                                    "object_type": 1,
                                    "config": {
                                        "options": [
                                            {
                                                "key": "Option1",
                                                "name": {
                                                    "zh_cn": "选项一",
                                                    "en_us": "Option1"
                                                },
                                                "description": {
                                                    "zh_cn": "第一个选项",
                                                    "en_us": "First Option"
                                                },
                                                "active_status": 1
                                            }
                                        ]
                                    }
                                },
                                "parent_id": "6949805467799537964",
                                "is_customized": true,
                                "is_required": false,
                                "is_visible": true,
                                "active_status": 1
                            }
                        ]
                    }
                ]
            }
        ],
        "page_token": "6930815272790114324",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1PortalApplySchemasResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}