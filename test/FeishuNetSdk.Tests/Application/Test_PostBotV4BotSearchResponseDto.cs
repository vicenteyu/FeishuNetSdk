// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostBotV4BotSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索机器人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 搜索机器人 响应体
/// <para>接口ID：7649652220287716543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v4/bot/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v4%2fbot%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostBotV4BotSearchResponseDto : TestBase
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
                "id": "7890123456abcdef",
                "display_info": "飞书<h>搜索</h>助手",
                "meta_data": {
                    "tenant_id": "7010970696222244883",
                    "enable_join_group": false,
                    "chat_id": "oc-7890123456abcdef",
                    "is_agent": false
                }
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "notice": "The query is too long and has been truncated to the first 50 characters for search."
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostBotV4BotSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}