namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 修改群菜单元信息 响应体
/// <para>接口ID：7174746098262704132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_item%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "chat_menu_item": {
            "action_type": "NONE",
            "redirect_link": {
                "common_url": "https://open.feishu.cn/",
                "ios_url": "https://open.feishu.cn/",
                "android_url": "https://open.feishu.cn/",
                "pc_url": "https://open.feishu.cn/",
                "web_url": "https://open.feishu.cn/"
            },
            "image_key": "img_v2_b0fbe905-7988-4282-b882-82edd010336j",
            "name": "报名",
            "i18n_names": {
                "zh_cn": "报名",
                "en_us": "Sign up",
                "ja_jp": "サインアップ"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}