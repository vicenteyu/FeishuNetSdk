// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1InterviewRegistrationSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取面试登记表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试登记表列表 响应体
/// <para>接口ID：7063273947417247745</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/interview-settings/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_registration_schema%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewRegistrationSchemasResponseDto : TestBase
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
                "name": "默认面试登记表",
                "is_used_as_interview": true,
                "object_list": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "登记表模块",
                            "en_us": "interview module"
                        },
                        "description": {
                            "zh_cn": "用于面试登记的模块",
                            "en_us": "module used for interview"
                        },
                        "setting": {
                            "object_type": 1,
                            "config": {
                                "options": [
                                    {
                                        "key": "test",
                                        "name": {
                                            "zh_cn": "模块选项",
                                            "en_us": "module option"
                                        },
                                        "description": {
                                            "zh_cn": "用于模块的选项",
                                            "en_us": "option for module"
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
                                    "zh_cn": "登记表字段",
                                    "en_us": "interview registration field"
                                },
                                "description": {
                                    "zh_cn": "用于登记表的字段",
                                    "en_us": "field for interview registration"
                                },
                                "setting": {
                                    "object_type": 1,
                                    "config": {
                                        "options": [
                                            {
                                                "key": "1",
                                                "name": {
                                                    "zh_cn": "选项A",
                                                    "en_us": "option A"
                                                },
                                                "description": {
                                                    "zh_cn": "字段选项",
                                                    "en_us": "option for field"
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
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewRegistrationSchemasResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}