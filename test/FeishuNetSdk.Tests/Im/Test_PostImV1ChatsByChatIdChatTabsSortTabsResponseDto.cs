namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 会话标签页排序 响应体
/// <para>接口ID：7111246605500628993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/sort_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fsort_tabs</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdChatTabsSortTabsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "chat_tabs": [
            {
                "tab_content": {},
                "tab_id": "7104164142520467475",
                "tab_type": "message"
            },
            {
                "tab_content": {},
                "tab_id": "7104164246245605395",
                "tab_type": "pin"
            },
            {
                "tab_content": {
                    "url": "https://www.feishu.cn/"
                },
                "tab_id": "7104168465417633811",
                "tab_name": "url2",
                "tab_type": "url"
            },
            {
                "tab_content": {
                    "doc": "https://example.feishu.cn/docx/doxbcjoYDoEtuwC0k0hryQBkSV1"
                },
                "tab_id": "7104168465379885076",
                "tab_name": "doc2",
                "tab_type": "doc"
            },
            {
                "tab_content": {
                    "url": "https://www.feishu.cn/"
                },
                "tab_id": "7104168141097287699",
                "tab_name": "url1",
                "tab_type": "url"
            },
            {
                "tab_content": {
                    "doc": "https://example.feishu.cn/docx/doxbcjoYDoEtuwC0k0hryQBkSV1"
                },
                "tab_id": "7104168141063716884",
                "tab_name": "doc1",
                "tab_type": "doc"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ChatsByChatIdChatTabsSortTabsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}