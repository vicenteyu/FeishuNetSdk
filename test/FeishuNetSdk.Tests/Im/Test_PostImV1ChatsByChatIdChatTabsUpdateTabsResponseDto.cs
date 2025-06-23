namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新会话标签页 响应体
/// <para>接口ID：7111246605500612609</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/update_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fupdate_tabs</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdChatTabsUpdateTabsResponseDto : TestBase
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
               "tab_id": "7101214603622940633",
                "tab_type": "message"
            },
            {
                "tab_id": "7103849256556953620",
                "tab_name": "update",
                "tab_type": "doc",
                "tab_content": {
                    "doc": "https://example.feishu.cn/docx/doxbcjoYDoEtuwC0k0hryQBkSV1"
                }
            },
            {
                "tab_id": "7103849256561164308",
                "tab_name": "url-update",
                "tab_type": "url",
                "tab_content": {
                    "doc": "https://www.feishu.cn/"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ChatsByChatIdChatTabsUpdateTabsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}