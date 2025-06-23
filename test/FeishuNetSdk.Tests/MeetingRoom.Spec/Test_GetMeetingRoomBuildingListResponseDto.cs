namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 获取建筑物列表 响应体
/// <para>接口ID：6907569523176636417</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-building-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugzNyUjL4cjM14CO3ITN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomBuildingListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "page_token":"1",
        "has_more":true,
        "buildings":[
            {
                "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
                "description":"Some description",
                "floors":[
                    "F1"
                ],
                "name":"Building name",
                "country_id": "country id",
                "district_id": "district id"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomBuildingListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}