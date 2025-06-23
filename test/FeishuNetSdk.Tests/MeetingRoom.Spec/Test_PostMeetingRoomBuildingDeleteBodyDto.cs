namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 删除建筑物 请求体
/// <para>接口ID：6907569742384005122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/delete-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzMxYjLzMTM24yMzEjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomBuildingDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomBuildingDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}