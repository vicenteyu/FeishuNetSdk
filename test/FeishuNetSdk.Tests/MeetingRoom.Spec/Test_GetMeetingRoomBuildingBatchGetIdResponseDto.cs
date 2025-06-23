namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询建筑物ID 响应体
/// <para>接口ID：6907569745299374082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-building-id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzMxYjL0MTM24CNzEjN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomBuildingBatchGetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "buildings":[
            {
                "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
                "custom_bulding_id":"test01"
            },
            {
                "building_id":"omb_38570e4f0fd9ecf15030d3cc8b388f3a",
                "custom_bulding_id":"test02"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomBuildingBatchGetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}