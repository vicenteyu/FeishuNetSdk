namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出自定义角色 响应体
/// <para>接口ID：7101134500528701443</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenRolesResponseDto : TestBase
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
                "role_id": "rola66uIZT",
                "role_name": "role1",
                "table_roles": [
                    {
                        "table_name": "table1",
                        "table_id": "tblFIgBzKEq75HSE",
                        "table_perm": 2,
                        "allow_add_record": false,
                        "allow_delete_record": true,
                        "rec_rule": {
                            "conjunction": "or",
                            "conditions": [
                                {
                                    "field_name": "单选",
                                    "field_type": 3,
                                    "operator": "is",
                                    "value": [
                                        "optbdVHf4q"
                                    ]
                                },
                                {
                                    "field_name": "人员",
                                    "field_type": 11,
                                    "operator": "contains",
                                    "value": null
                                },
                                {
                                    "field_name": "",
                                    "field_type": 1003,
                                    "operator": "contains",
                                    "value": null
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
                                    "field_type": 11,
                                    "operator": "contains",
                                    "value": null
                                },
                                {
                                    "field_name": "多选",
                                    "field_type": 4,
                                    "operator": "is",
                                    "value": [
                                        "opttgKOTSt",
                                        "optWcdXR0W"
                                    ]
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
                ]
            }
        ],
        "page_token": "rola66uIZT",
        "has_more": false,
        "total": 1
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenRolesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}