namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 机器人单聊即时提醒 响应体
/// <para>接口ID：7350335258430799873</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/bot_time_sentive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fbot_time_sentive</para>
/// </summary>
[TestClass]
public class Test_PatchImV2FeedCardsBotTimeSentiveResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "failed_user_reasons": [
            {
                "error_code": 0,
                "error_message": "The user is not in the chat",
                "user_id": "ou_679eaeb583654bff73fefcc6e6371301"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV2FeedCardsBotTimeSentiveResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}