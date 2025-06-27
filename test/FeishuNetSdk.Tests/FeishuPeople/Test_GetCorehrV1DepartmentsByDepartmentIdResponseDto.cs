// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1DepartmentsByDepartmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单个部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个部门 响应体
/// <para>接口ID：7017707615190974467</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1DepartmentsByDepartmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "department": {
            "id": "6969828847121885087",
            "sub_type": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "manager": "6893013238632416776",
            "is_confidential": true,
            "hiberarchy_common": {
                "parent_id": "4719168654814483759",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "type": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "active": true,
                "effective_time": "2020-05-01 00:00:00",
                "expiration_time": "2020-05-02 00:00:00",
                "code": "12456",
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "tree_order": "001000",
                "list_order": "001000-001000",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            },
            "effective_time": "2020-05-01 00:00:00",
            "expiration_time": "2020-05-02 00:00:00",
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ],
            "cost_center_id": "7142384817131652652",
            "staffing_model": {
                "enum_name": "position",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1DepartmentsByDepartmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}