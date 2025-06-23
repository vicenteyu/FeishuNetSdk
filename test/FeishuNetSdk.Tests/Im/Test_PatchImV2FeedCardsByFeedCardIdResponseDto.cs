namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 即时提醒 响应体
/// <para>接口ID：7291232621641039875</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV2FeedCardsByFeedCardIdResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV2FeedCardsByFeedCardIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}