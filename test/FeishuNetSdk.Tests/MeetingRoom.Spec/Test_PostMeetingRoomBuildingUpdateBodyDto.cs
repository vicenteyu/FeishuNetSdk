// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMeetingRoomBuildingUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新建筑物 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 更新建筑物 请求体
/// <para>接口ID：6907569744330932225</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/update-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETNwYjLxUDM24SM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomBuildingUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
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
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomBuildingUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}