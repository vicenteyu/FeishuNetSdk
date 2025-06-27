// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1MeetingListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询会议明细 响应体
/// <para>接口ID：7194805625628033027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting_list%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1MeetingListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "meeting_list": [
            {
                "meeting_id": "705605196",
                "meeting_topic": "讨论会",
                "meeting_type": 1,
                "organizer": "kehan",
                "department": "development",
                "user_id": "92f879",
                "employee_id": "202105149765",
                "email": "xxxx@163.com",
                "mobile": "021-673288",
                "meeting_start_time": "2022.12.23 11:16:59 (GMT+08:00)",
                "meeting_end_time": "2022.12.23 11:18:51 (GMT+08:00)",
                "meeting_duration": "00:01:52",
                "number_of_participants": "1",
                "number_of_devices": "1",
                "audio": true,
                "video": true,
                "sharing": false,
                "recording": false,
                "telephone": false,
                "reserved_rooms": [
                    {
                        "room_id": "omm_12381298739",
                        "room_name": "room123"
                    }
                ],
                "has_related_document": false
            }
        ],
        "page_token": "20",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1MeetingListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}