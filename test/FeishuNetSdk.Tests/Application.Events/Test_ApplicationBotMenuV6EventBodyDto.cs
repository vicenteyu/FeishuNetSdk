namespace FeishuNetSdk.Tests.Application.Events;

/// <summary>
/// 测试 机器人自定义菜单事件 事件体
/// <para>接口ID：7176243808379977730</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/bot-v3/events/menu</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fbot%2fevents%2fmenu</para>
/// </summary>
[TestClass]
public class Test_ApplicationBotMenuV6EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "application.bot.menu_v6",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "operator": {
            "operator_name": "张三",
            "operator_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            }
        },
        "event_key": "menu2022********67dfc8b885136",
        "timestamp": 1669364458
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Application.Events.ApplicationBotMenuV6EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}