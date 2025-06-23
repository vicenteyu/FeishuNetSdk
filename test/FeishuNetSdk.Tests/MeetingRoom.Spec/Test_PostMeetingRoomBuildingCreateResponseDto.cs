namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 创建建筑物 响应体
/// <para>接口ID：6907569524099760129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNwYjLwUDM24CM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomBuildingCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomBuildingCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}