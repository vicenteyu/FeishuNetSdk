namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 添加会话标签页 响应体
/// <para>接口ID：7111246605500563457</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdChatTabsResponseDto : TestBase
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
                "tab_id": "7101214603622940671",
                "tab_name": "文档",
                "tab_type": "doc",
                "tab_content": {
                    "doc": "https://example.feishu.cn/wiki/wikcnPIcqWjJQwkwDzrB9t40123xz"
                }
            },
            {
                "tab_id": "7158333373373759422",
                "tab_name": "测试",
                "tab_type": "url",
                "tab_content": {
                    "url": "https://www.test.cn"
                },
                "tab_config": {
                    "icon_key": "img_v2_b99741-7628-4abd-aad0-b881e4db83ig",
                    "is_built_in": true
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ChatsByChatIdChatTabsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}