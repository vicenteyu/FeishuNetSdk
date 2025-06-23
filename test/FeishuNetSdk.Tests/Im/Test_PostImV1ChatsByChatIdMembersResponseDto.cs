namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 将用户或机器人拉入群聊 响应体
/// <para>接口ID：6946222931479609345</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "invalid_id_list": [
            "4d7a3c6g"
        ],
        "not_existed_id_list": [
            "4d7a3c6g"
        ],
        "pending_approval_id_list": [
            "4d7a3c6g"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ChatsByChatIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}