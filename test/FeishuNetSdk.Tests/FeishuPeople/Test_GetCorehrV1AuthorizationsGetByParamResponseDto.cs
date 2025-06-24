// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1AuthorizationsGetByParamResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单个用户授权 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个用户授权 响应体
/// <para>接口ID：7372022997609922562</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/get_by_param</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fget_by_param</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1AuthorizationsGetByParamResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "role_authorization": {
            "employment_id": "6967639606963471902",
            "permission_detail_list": [
                {
                    "role": {
                        "id": "7034393015968122400",
                        "code": "department_manager",
                        "name": {
                            "zh_cn": "cn",
                            "en_us": "en"
                        },
                        "description": {
                            "zh_cn": "cn",
                            "en_us": "en"
                        },
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
                                    "zh_cn": "cn",
                                    "en_us": "en"
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
                                "entity_key": "员工",
                                "entity_name": {
                                    "zh_cn": "cn",
                                    "en_us": "en"
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
                                "expression": "1 and 2"
                            }
                        }
                    ],
                    "update_time": "1720584039"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1AuthorizationsGetByParamResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}