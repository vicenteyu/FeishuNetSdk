// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostBotV4BotSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索机器人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 搜索机器人 请求体
/// <para>接口ID：7649652220287716543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v4/bot/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v4%2fbot%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostBotV4BotSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "会议助手",
    "filter": {
        "chat_ids": [
            "oc-7890123456abcdef"
        ],
        "has_chatter": false
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostBotV4BotSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}