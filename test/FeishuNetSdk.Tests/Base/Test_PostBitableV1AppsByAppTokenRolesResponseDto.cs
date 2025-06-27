// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenRolesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增自定义角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增自定义角色 响应体
/// <para>接口ID：7101134500528734211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenRolesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "data": {
        "role": {
            "role_name": "role1",
            "table_roles": [
                {
                    "table_name": "table1",
                    "table_id": "tblFIgBzKEq75HSE",
                    "table_perm": 2,
                    "rec_rule": {
                        "conjunction": "or",
                        "conditions": [
                            {
                                "field_name": "单选",
                                "operator": "is",
                                "field_type": 3,
                                "value": [
                                    "optbdVHf4q"
                                ]
                            },
                            {
                                "value": null,
                                "field_name": "人员",
                                "operator": "contains",
                                "field_type": 11
                            },
                            {
                                "operator": "contains",
                                "field_type": 1003,
                                "value": null,
                                "field_name": ""
                            }
                        ],
                        "other_perm": 0
                    },
                    "field_perm": {
                        "单选": 1,
                        "年龄": 2
                    }
                },
                {
                    "table_name": "table2",
                    "table_id": "tblMPI6OC1aWvTvs",
                    "table_perm": 1,
                    "rec_rule": {
                        "conditions": [
                            {
                                "field_name": "人员",
                                "operator": "contains",
                                "field_type": 11,
                                "value": null
                            },
                            {
                                "operator": "is",
                                "field_type": 4,
                                "value": [
                                    "opttgKOTSt",
                                    "optWcdXR0W"
                                ],
                                "field_name": "多选"
                            }
                        ],
                        "other_perm": 0,
                        "conjunction": "and"
                    }
                },
                {
                    "table_name": "table3",
                    "table_id": "tblmkLF7Tg6IWbRb",
                    "table_perm": 0
                },
                {
                    "table_name": "table4",
                    "table_id": "tbl5VQHDTms19Qe7",
                    "table_perm": 4
                }
            ],
            "block_roles": [
                {
                    "block_id": "blknkqrP3RqUkcAW",
                    "block_type": "dashboard",
                    "block_perm": 0
                },
                {
                    "block_id": "blkAjxjWKvbBi7EA",
                    "block_type": "dashboard",
                    "block_perm": 1
                }
            ],
            "role_id": "rolgFH5DO4"
        }
    },
    "code": 0,
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenRolesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}