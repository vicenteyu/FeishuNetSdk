// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMeetingRoomBuildingBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询建筑物详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询建筑物详情 响应体
/// <para>接口ID：6907569523177635841</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/query-building-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukzNyUjL5cjM14SO3ITN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomBuildingBatchGetResponseDto : TestBase
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
                "description":"Some description",
                "floors":[
                    "F1"
                ],
                "name":"Building name",
                "country_id": "Country id",
                "district_id": "District id"
            },
            {
                "building_id":"omb_38570e4f0fd9ecf15030d3cc8b388f3a",
                "description":"Some description",
                "floors":[
                    "F1",
                    "F2"
                ],
                "name":"Building name_2",
                "country_id": "Country id",
                "district_id": "District id"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomBuildingBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}