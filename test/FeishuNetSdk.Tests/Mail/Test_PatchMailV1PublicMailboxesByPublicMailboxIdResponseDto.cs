namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 修改公共邮箱部分信息 响应体
/// <para>接口ID：6954915601883136003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchMailV1PublicMailboxesByPublicMailboxIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "public_mailbox_id": "xxx",
        "email": "xx@xx.xx",
        "name":"xxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PatchMailV1PublicMailboxesByPublicMailboxIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}