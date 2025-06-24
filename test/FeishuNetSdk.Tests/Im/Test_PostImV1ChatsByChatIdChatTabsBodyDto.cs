// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1ChatsByChatIdChatTabsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加会话标签页 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 添加会话标签页 请求体
/// <para>接口ID：7111246605500563457</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdChatTabsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "chat_tabs": [
        {
            "tab_name": "文档",
            "tab_type": "doc",
            "tab_content": {
                "url": "https://www.feishu.cn",
                "doc": "https://example.feishu.cn/wiki/wikcnPIcqWjJQwkwDzrB9t40123xz",
                "meeting_minute": "https://example.feishu.cn/docs/doccnvIXbV22i6hSD3utar4123dx",
                "task": "https://bytedance.feishu.cn/client/todo/task_list?guid=fa03fb6d-344b-47d9-83e3-049e3b3da931"
            },
            "tab_config": {
                "icon_key": "img_v2_b99741-7628-4abd-aad0-b881e4db83ig",
                "is_built_in": false
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdChatTabsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}