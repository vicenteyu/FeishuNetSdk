namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 创建建筑物 请求体
/// <para>接口ID：6907569524099760129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNwYjLwUDM24CM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomBuildingCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name":"测试建筑",
    "floors":[
        "F1",
        "F2",
        "F3",
        "F4"
    ],
    "country_id":"1814991",
    "district_id":"2034437",
    "custom_building_id":"test_building_01"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomBuildingCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}