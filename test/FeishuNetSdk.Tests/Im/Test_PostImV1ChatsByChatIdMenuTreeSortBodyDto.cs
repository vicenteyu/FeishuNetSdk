namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 排序群菜单 请求体
/// <para>接口ID：7174746098262687748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/sort</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fsort</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdMenuTreeSortBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "chat_menu_top_level_ids": [
        "6936075528890826780"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdMenuTreeSortBodyDto>(json);
        Assert.IsNotNull(result);
    }
}