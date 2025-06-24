// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutImV2AppFeedCardBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用消息流卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新应用消息流卡片 请求体
/// <para>接口ID：7302258202712473628</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/app_feed_card/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card-batch%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV2AppFeedCardBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "feed_cards": [
        {
            "app_feed_card": {
                "biz_id": "096e2927-40a6-41a3-9562-314d641d09ae",
                "title": "主标题",
                "avatar_key": "v3_0041_007bca9f-67ba-4199-bf00-4031b12cf226",
                "preview": "预览信息",
                "status_label": {
                    "text": "标签文字",
                    "type": "primary"
                },
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
                },
                "link": {
                    "link": "https://www.feishu.cn/"
                },
                "time_sensitive": false,
                "notify": {
                    "close_notify": true,
                    "custom_sound_text": "您有新的订单",
                    "with_custom_sound": true
                }
            },
            "user_id": "ou_a0553eda9014c201e6969b478895c230",
            "update_fields": [
                "1"
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV2AppFeedCardBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}