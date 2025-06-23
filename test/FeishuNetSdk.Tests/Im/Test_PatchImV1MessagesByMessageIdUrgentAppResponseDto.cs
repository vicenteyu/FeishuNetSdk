namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 发送应用内加急 响应体
/// <para>接口ID：6948245234036621340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_app</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_app</para>
/// </summary>
[TestClass]
public class Test_PatchImV1MessagesByMessageIdUrgentAppResponseDto : TestBase
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
            "6921304923074478100"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV1MessagesByMessageIdUrgentAppResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}