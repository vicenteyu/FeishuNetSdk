namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建收信规则 请求体
/// <para>接口ID：7275929163676172291</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-rule/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-rule%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdRulesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "condition": {
        "match_type": 1,
        "items": [
            {
                "type": 1,
                "operator": 1,
                "input": "hello@world.com"
            }
        ]
    },
    "action": {
        "items": [
            {
                "type": 1,
                "input": "283412371233"
            }
        ]
    },
    "ignore_the_rest_of_rules": false,
    "name": "将李三的邮件标记为垃圾邮件",
    "is_enable": false
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdRulesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}