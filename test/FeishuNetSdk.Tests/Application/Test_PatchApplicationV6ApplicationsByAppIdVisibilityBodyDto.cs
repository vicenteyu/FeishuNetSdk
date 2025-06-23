namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用可用范围 请求体
/// <para>接口ID：7278520881743740931</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/admin/patch-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV6ApplicationsByAppIdVisibilityBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "add_visible_list": {
        "user_ids": [
            "ou_84aad35d084aa403a838cf73ee18467"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g193821"
        ]
    },
    "del_visible_list": {
        "user_ids": [
            "ou_84aad35d084aa403a838cf73ee18467"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g193821"
        ]
    },
    "add_invisible_list": {
        "user_ids": [
            "ou_84aad35d084aa403a838cf73ee18467"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g193821"
        ]
    },
    "del_invisible_list": {
        "user_ids": [
            "ou_84aad35d084aa403a838cf73ee18467"
        ],
        "department_ids": [
            "od-4e6ac4d14bcd5071a37a39de902c7141"
        ],
        "group_ids": [
            "g193821"
        ]
    },
    "is_visible_to_all": false
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV6ApplicationsByAppIdVisibilityBodyDto>(json);
        Assert.IsNotNull(result);
    }
}