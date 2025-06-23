namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 发送短信加急 响应体
/// <para>接口ID：6948245234036637724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_sms</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_sms</para>
/// </summary>
[TestClass]
public class Test_PatchImV1MessagesByMessageIdUrgentSmsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "invalid_user_id_list": [
            "ou_6yf8af6bgb9100449565764t3382b168"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV1MessagesByMessageIdUrgentSmsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}