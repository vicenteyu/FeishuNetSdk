namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用通讯录权限范围配置 请求体
/// <para>接口ID：7278520881743724547</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/admin/patch-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-contacts_range%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV6ApplicationsByAppIdContactsRangeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "contacts_range_type": "some",
    "add_visible_list": {
        "user_ids": [
            "ou_7dab8a3d3cdcc9da365777c7ad535d62"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g12334"
        ]
    },
    "del_visible_list": {
        "user_ids": [
            "ou_7dab8a3d3cdcc9da365777c7ad535d62"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g12334"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV6ApplicationsByAppIdContactsRangeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}