// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1RegistrationSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取信息登记表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取信息登记表列表 响应体
/// <para>接口ID：7259225956346232860</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/application/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fregistration_schema%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1RegistrationSchemasResponseDto : TestBase
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
                "id": "7044739584859326764",
                "name": "默认信息登记表",
                "scenarios": [
                    5
                ],
                "objects": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "简历",
                            "en_us": "Resume"
                        },
                        "description": {
                            "zh_cn": "用于信息登记的模块",
                            "en_us": "module use for info registry"
                        },
                        "setting": {
                            "object_type": 1,
                            "config": {
                                "options": [
                                    {
                                        "key": "1",
                                        "name": {
                                            "zh_cn": "模块选项",
                                            "en_us": "module option"
                                        },
                                        "description": {
                                            "zh_cn": "模块适用的选项",
                                            "en_us": "option use for mudule"
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
                                    "zh_cn": "简历自定义字段",
                                    "en_us": "resume custom field"
                                },
                                "description": {
                                    "zh_cn": "用于简历的字段",
                                    "en_us": "field use for resume"
                                },
                                "setting": {
                                    "object_type": 1,
                                    "config": {
                                        "options": [
                                            {
                                                "key": "1",
                                                "name": {
                                                    "zh_cn": "字段选项",
                                                    "en_us": "option for field"
                                                },
                                                "description": {
                                                    "zh_cn": "用于字段的选项",
                                                    "en_us": "option use for field"
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1RegistrationSchemasResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}