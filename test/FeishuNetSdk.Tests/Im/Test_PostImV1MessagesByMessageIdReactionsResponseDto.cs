namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 添加消息表情回复 响应体
/// <para>接口ID：6990603997012312066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdReactionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reaction_id": "ZCaCIjUBVVWSrm5L-3ZTw****",
        "operator": {
            "operator_id": "ou_ff0b7ba35fb****",
            "operator_type": "user"
        },
        "action_time": "1663054162546",
        "reaction_type": {
            "emoji_type": "SMILE"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1MessagesByMessageIdReactionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}