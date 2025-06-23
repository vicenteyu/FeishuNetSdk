namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 删除会话标签页 响应体
/// <para>接口ID：7111246605500579841</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/delete_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fdelete_tabs</para>
/// </summary>
[TestClass]
public class Test_DeleteImV1ChatsByChatIdChatTabsDeleteTabsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "chat_tabs": [{
                "tab_id": "7101214603622940633",
                "tab_type": "message"
            },
            {
                "tab_id": "7101214603622940671",
                "tab_name": "文档",
                "tab_type": "doc",
                "tab_content": {
                    "doc": "https://example.feishu.cn/wiki/wikcnPIcqWjJQwkwDzrB9t40123xz"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.DeleteImV1ChatsByChatIdChatTabsDeleteTabsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}