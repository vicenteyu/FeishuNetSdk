namespace FeishuNetSdk.Tests.Application.Spec;

/// <summary>
/// 测试 获取用户自定义常用的应用 响应体
/// <para>接口ID：7218970579747110913</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/workplace-v1/app_recommend_rule/favourite</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v5%2fapplication%2ffavourite</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV5ApplicationsFavouriteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "new-e11ee058b4a8ed2881da11ac7e37c4fc",
        "total_count": 7,
        "has_more": false,
        "app_list": [
            {
                "app_id": "cli_9f9f8825d53xxxx",
                "app_name": "效率工具",
                "description": "提升办公效率的一款应用",
                "app_type": "app",
                "avatar_url": "https://s1-xxxxxx/static-resource/v1/ca597e6e-28c1-4178-961a-1xxxxx",
                "open_methods": [
                    {
                        "type": "mobile_gadget",
                        "applink": "https://applink.feishu.cn/client/web_app/open?appId=cli_9f9f8825d53xxxx"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.Spec.GetApplicationV5ApplicationsFavouriteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}