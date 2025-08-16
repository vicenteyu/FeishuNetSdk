// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1AuthorizationsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询用户授权 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询用户授权 响应体
/// <para>接口ID：7372022997609906178</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1AuthorizationsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "employment_id": "6967639606963471902",
                "permission_detail_list": [
                    {
                        "role": {
                            "id": "7034393015968122400",
                            "code": "department_manager",
                            "name": {
                                "zh_cn": "部门经理",
                                "en_us": "department manager"
                            },
                            "active_status": 1,
                            "description": {
                                "zh_cn": "中文描述",
                                "en_us": "英文描述"
                            },
                            "group_type": 1,
                            "created_by": "6967639606963471902",
                            "update_time": "1720584039",
                            "org_truncation": [
                                {
                                    "org_key": "department",
                                    "type": 0,
                                    "depth": 0
                                }
                            ]
                        },
                        "assigned_organization_list": [
                            [
                                {
                                    "org_key": "department",
                                    "org_name": {
                                        "zh_cn": "部门",
                                        "en_us": "department"
                                    },
                                    "org_id_list": [
                                        "6967639606963471902"
                                    ]
                                }
                            ]
                        ],
                        "grantor_rule_list": [
                            {
                                "rule_dimension": {
                                    "entity_key": "user",
                                    "entity_name": {
                                        "zh_cn": "员工",
                                        "en_us": "User"
                                    }
                                },
                                "rule_type": 1,
                                "expression": {
                                    "conditions": [
                                        {
                                            "left": {
                                                "type": 1,
                                                "value": "a",
                                                "lookup_value": "1",
                                                "lookup_type": "user"
                                            },
                                            "right": {
                                                "type": 1,
                                                "value": "a",
                                                "lookup_value": "1",
                                                "lookup_type": "user"
                                            },
                                            "operator": 1,
                                            "right_value_type": 1
                                        }
                                    ],
                                    "logic_expression": "1 and 2"
                                }
                            }
                        ],
                        "update_time": "1720584039"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1AuthorizationsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}