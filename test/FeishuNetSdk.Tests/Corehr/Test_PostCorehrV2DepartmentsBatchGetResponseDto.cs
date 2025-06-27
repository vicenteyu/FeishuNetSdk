// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DepartmentsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门 响应体
/// <para>接口ID：7280432392631549953</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsBatchGetResponseDto : TestBase
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
                "id": "4719456877659520852",
                "version_id": "6890452208593372611",
                "department_name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "sub_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "parent_department_id": "4719456877659520111",
                "manager": "6893013238632416777",
                "tree_order": "001000",
                "list_order": "001000-001000",
                "code": "D00000456",
                "is_root": false,
                "is_confidential": false,
                "effective_date": "2020-05-01",
                "expiration_date": "2020-05-02",
                "active": true,
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ],
                "staffing_model": {
                    "enum_name": "job",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "cost_center_id": "7142384817131652652",
                "created_time": "2020-05-01 00:00:00",
                "updated_time": "2020-05-02 00:00:00",
                "created_by": "6893013238632416777",
                "updated_by": "6893013238632416777",
                "record_created_time": "2020-05-01 00:00:00",
                "record_updated_time": "2020-05-02 00:00:00",
                "record_created_by": "6893013238632416777",
                "record_updated_by": "6893013238632416777"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}