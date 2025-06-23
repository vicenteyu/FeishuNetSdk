namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 邀请参会人 响应体
/// <para>接口ID：6960861158593134596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/invite</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2finvite</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1MeetingsByMeetingIdInviteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "invite_results": [
            {
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "user_type": 1,
                "status": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PatchVcV1MeetingsByMeetingIdInviteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}