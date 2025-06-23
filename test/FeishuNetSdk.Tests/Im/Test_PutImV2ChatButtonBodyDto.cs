namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新消息流卡片按钮 请求体
/// <para>接口ID：7302258202712506396</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat_button%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV2ChatButtonBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "ou_89553eda9014c201e6969b478895c276"
    ],
    "chat_id": "oc_a0553eda9014c201e6969b478895c230",
    "buttons": {
        "buttons": [
            {
                "multi_url": {
                    "url": "https://www.feishu.cn/",
                    "android_url": "https://www.feishu.cn/",
                    "ios_url": "https://www.feishu.cn/",
                    "pc_url": "https://www.feishu.cn/"
                },
                "action_type": "url_page",
                "text": {
                    "text": "文本"
                },
                "button_type": "default",
                "action_map": {
                    "foo": "bar"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV2ChatButtonBodyDto>(json);
        Assert.IsNotNull(result);
    }
}