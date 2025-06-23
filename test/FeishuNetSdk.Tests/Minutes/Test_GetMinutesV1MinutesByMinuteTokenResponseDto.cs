namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 获取妙记信息 响应体
/// <para>接口ID：7181729161035628545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/minutes-v1/minute/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMinutesV1MinutesByMinuteTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "minute": {
            "token": "obcnq3b9jl72l83w4f14xxxx",
            "owner_id": "ou_612b787ccd3259fb3c816b3f678dxxxx",
            "create_time": "1669098360477",
            "title": "xxx的视频会议",
            "cover": "https://internal-api-drive-stream.feishu-pre.cn/space/api/box/stream/download/all/boxcncsI4EIhCSA1RLDsXDpxxxx",
            "duration": "314000",
            "url": "https://bytedance.feishu-pre.cn/minutes/obcnq3b9jl72l83w4f14xxxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.GetMinutesV1MinutesByMinuteTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}