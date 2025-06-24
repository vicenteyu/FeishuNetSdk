// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1ChatsByChatIdChatTabsSortTabsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 会话标签页排序 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 会话标签页排序 请求体
/// <para>接口ID：7111246605500628993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/sort_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fsort_tabs</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdChatTabsSortTabsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tab_ids": [
        "6936075528890826780"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdChatTabsSortTabsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}