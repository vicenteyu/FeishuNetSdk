namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群公告信息 响应体
/// <para>接口ID：6946222929790435356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fget</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsByChatIdAnnouncementResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "content": "xxx",
        "revision": "12",
        "create_time": "1609296809",
        "update_time": "1609296809",
        "owner_id_type": "open_id",
        "owner_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
        "modifier_id_type": "open_id",
        "modifier_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsByChatIdAnnouncementResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}