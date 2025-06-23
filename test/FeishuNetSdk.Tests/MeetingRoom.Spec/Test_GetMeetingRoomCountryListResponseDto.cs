namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 获取国家地区列表 响应体
/// <para>接口ID：6907569524100808705</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-country/region-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTNwYjL0UDM24CN1AjN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomCountryListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "countries":[
            {
                "country_id":"1814991",
                "name":"中国"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomCountryListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}