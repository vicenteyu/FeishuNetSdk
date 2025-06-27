// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApplicationV5ApplicationsRecommendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取管理员推荐的应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application.Spec;

/// <summary>
/// 测试 获取管理员推荐的应用 响应体
/// <para>接口ID：7218970579747127297</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/workplace-v1/app_recommend_rule/recommend</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v5%2fapplication%2frecommend</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV5ApplicationsRecommendResponseDto : TestBase
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
        "page_size": 10,
        "total_count": 7,
        "has_more": false,
        "app_list": [
            {
                "app_id": "cli_9f9f8825d53xxxx",
                "app_name": "效率工具",
                "description": "提升办公效率的一款应用效率工具",
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.Spec.GetApplicationV5ApplicationsRecommendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}