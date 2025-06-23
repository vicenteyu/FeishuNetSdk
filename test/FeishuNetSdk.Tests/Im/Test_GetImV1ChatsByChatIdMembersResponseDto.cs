namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群成员列表 响应体
/// <para>接口ID：6946222929790550044</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fget</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsByChatIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "member_id_type": "open_id",
                "member_id": "ou_9204a37300b3700d61effaa439f34295",
                "name": "张三",
                "tenant_key": "736588c9260f175d"
            }
        ],
        "page_token": "dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==",
        "has_more": true,
        "member_total": 2
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsByChatIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}