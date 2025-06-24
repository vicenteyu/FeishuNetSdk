// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutBaseV2AppsByAppTokenRolesByRoleIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新自定义角色 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新自定义角色 请求体
/// <para>接口ID：7473089245106323460</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/advanced-permission/app-role/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fadvanced-permission%2fbase-v2%2fapp-role%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBaseV2AppsByAppTokenRolesByRoleIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "role_name": "自定义权限1",
    "table_roles": [
        {
            "table_perm": 0,
            "table_name": "数据表1",
            "table_id": "tblKz5D60T4JlfcT",
            "rec_rule": {
                "conditions": [
                    {
                        "field_name": "单选",
                        "operator": "is",
                        "value": [
                            "optbdVHf4q"
                        ]
                    }
                ],
                "conjunction": "and",
                "other_perm": 1
            },
            "other_rec_rule": {
                "conditions": [
                    {
                        "field_name": "单选",
                        "operator": "is",
                        "value": [
                            "optbdVHf4q"
                        ]
                    }
                ],
                "conjunction": "and"
            },
            "field_perm": {
                "姓名": 1,
                "年龄": 2
            },
            "allow_add_record": true,
            "allow_delete_record": true,
            "view_perm": 2,
            "view_rules": {
                "vewEYknYcC": 0
            },
            "field_action_rules": {
                "select_option_edit": {
                    "单选1": 0
                }
            }
        }
    ],
    "block_roles": [
        {
            "block_id": "blknkqrP3RqUkcAW",
            "block_perm": 0
        }
    ],
    "base_rule": {
        "base_complex_edit": 1,
        "copy": 0
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PutBaseV2AppsByAppTokenRolesByRoleIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}