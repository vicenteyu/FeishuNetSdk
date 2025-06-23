namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增自定义角色 请求体
/// <para>接口ID：7101134500528734211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenRolesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "role_name": "普通用户",
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
                "other_perm": 0
            },
            "field_perm": {
                "姓名": 1,
                "年龄": 2
            },
            "allow_add_record": true,
            "allow_delete_record": true
        }
    ],
    "block_roles": [
        {
            "block_id": "blknkqrP3RqUkcAW",
            "block_perm": 0
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenRolesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}