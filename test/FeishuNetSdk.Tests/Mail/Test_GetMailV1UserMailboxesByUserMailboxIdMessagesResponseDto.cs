namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出邮件 响应体
/// <para>接口ID：7275929163676221443</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesResponseDto : TestBase
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
            "ZWEyNGRmY2QtOTVlNy00NzlhLTg5MjItMjFjOTQ5ZjIzZjJl"
        ],
        "page_token": "xxx",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}