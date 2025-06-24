// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMeetingRoomDistrictListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取城市列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 获取城市列表 响应体
/// <para>接口ID：6907569523176947713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-city-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTNwYjL1UDM24SN1AjN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomDistrictListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "districts":[
            {
                "district_id":"1796236",
                "name":"上海"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomDistrictListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}