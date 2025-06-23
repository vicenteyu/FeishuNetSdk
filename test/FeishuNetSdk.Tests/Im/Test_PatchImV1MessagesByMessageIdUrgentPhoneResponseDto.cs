namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 发送电话加急 响应体
/// <para>接口ID：6948245234036654108</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_phone</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_phone</para>
/// </summary>
[TestClass]
public class Test_PatchImV1MessagesByMessageIdUrgentPhoneResponseDto : TestBase
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
            "2921304923074478100"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV1MessagesByMessageIdUrgentPhoneResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}