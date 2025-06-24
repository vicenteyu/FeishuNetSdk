// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ResourceReservationListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室预定数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询会议室预定数据 响应体
/// <para>接口ID：7194805625628065795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fresource_reservation_list%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ResourceReservationListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "room_reservation_list": [
            {
                "room_id": "omm_4de32cf10a4358788ff4e09e37ebbf9b",
                "room_name": "VIP Meeting Room",
                "event_title": "飞书邀请的日程",
                "reserver": "kehan",
                "reserver_user_id": "ou_1234567(UserID);cli_123123(BotID)",
                "department_of_reserver": "development",
                "guests_number": "5",
                "accepted_number": "2",
                "event_start_time": "2022.12.17 21:00:00 (GMT+08:00)",
                "event_end_time": "2022.12.17 22:00:00 (GMT+08:00)",
                "event_duration": "1:00:00",
                "reservation_status": "预定成功",
                "check_in_device": "签到板",
                "room_check_in_status": "已签到",
                "check_in_time": "2022.12.09 13:35:30 (GMT+08:00)",
                "is_release_early": "已释放（手动释放）",
                "releasing_person": "kehan",
                "releasing_time": "2022.12.20 11:25:15 (GMT+08:00)"
            }
        ],
        "page_token": "20",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ResourceReservationListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}