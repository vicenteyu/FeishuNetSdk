// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-30
//
// Last Modified By : yxr
// Last Modified On : 2026-10-30
// ************************************************************************
// <copyright file="Test_DeleteBotV3BotMenuBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除千人千面菜单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 删除千人千面菜单 请求体
/// <para>接口ID：7570924844655607827</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v3/bot_menu/delete_bot_menu</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v3%2fbot_menu%2fdelete_bot_menu</para>
/// </summary>
[TestClass]
public class Test_DeleteBotV3BotMenuBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.DeleteBotV3BotMenuBodyDto>(json);
        Assert.IsNotNull(result);
    }
}