// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1RolesByRoleIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取角色详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取角色详情 响应体
/// <para>接口ID：7351241605105090564</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/auth/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2frole%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1RolesByRoleIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "role": {
            "id": "6930815272790114324",
            "name": {
                "zh_cn": "招聘 HRBP",
                "en_us": "Recruitment HRBP"
            },
            "description": {
                "zh_cn": "赋予HRBP的权限",
                "en_us": "Authority given to HRBP"
            },
            "modify_time": "1716535727510",
            "role_status": 1,
            "role_type": 1,
            "scope_of_application": 1,
            "has_business_management_scope": true,
            "socail_permission_collection": {
                "feature_permissions": [
                    {
                        "id": "10101000",
                        "name": {
                            "zh_cn": "查看人才",
                            "en_us": "View talent"
                        }
                    }
                ],
                "management_permissions": [
                    {
                        "id": "20101001",
                        "name": {
                            "zh_cn": "门店管理",
                            "en_us": "Store management"
                        }
                    }
                ],
                "data_permissions": [
                    {
                        "id": "30203005",
                        "name": {
                            "zh_cn": "私密备注",
                            "en_us": "Private notes"
                        },
                        "select_status": 0
                    }
                ],
                "business_management_scopes": [
                    {
                        "entity": {
                            "code": "application",
                            "name": {
                                "zh_cn": "投递",
                                "en_us": "Application"
                            }
                        },
                        "permission_groups": [
                            {
                                "permission_ids": [
                                    "6930815272790114324"
                                ],
                                "scope_rule": {
                                    "rule_type": 1
                                }
                            }
                        ]
                    }
                ]
            },
            "campus_permission_collection": {
                "feature_permissions": [
                    {
                        "id": "10101002",
                        "name": {
                            "zh_cn": "查看投递",
                            "en_us": "View application"
                        }
                    }
                ],
                "management_permissions": [
                    {
                        "id": "20101002",
                        "name": {
                            "zh_cn": "编辑权限",
                            "en_us": "Edit permissions"
                        }
                    }
                ],
                "data_permissions": [
                    {
                        "id": "30103001",
                        "name": {
                            "zh_cn": "操作记录",
                            "en_us": "Action history"
                        },
                        "select_status": 0
                    }
                ],
                "business_management_scopes": [
                    {
                        "entity": {
                            "code": "application",
                            "name": {
                                "zh_cn": "投递",
                                "en_us": "application"
                            }
                        },
                        "permission_groups": [
                            {
                                "permission_ids": [
                                    "6930815272790114324"
                                ],
                                "scope_rule": {
                                    "rule_type": 0
                                }
                            }
                        ]
                    }
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1RolesByRoleIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}