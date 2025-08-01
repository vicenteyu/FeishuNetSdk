// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_GetVcV1ParticipantListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询参会人明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询参会人明细 响应体
/// <para>接口ID：7194805625628147715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fparticipant_list%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ParticipantListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "participants": [
            {
                "participant_name": "kehan",
                "department": "development",
                "user_id": "8efq90",
                "meeting_room_id": "omm_8efq90",
                "employee_id": "202205789",
                "phone": "021-883889",
                "email": "xxxx@163.com",
                "device": "windows",
                "app_version": "5.26.0-alpha.38",
                "public_ip": "27.xx.xx.183",
                "internal_ip": "192.xx.xx.13",
                "use_rtc_proxy": false,
                "location": "东莞",
                "network_type": "wifi",
                "protocol": "udp",
                "microphone": "麦克风阵列 (Realtek(R) Audio)",
                "speaker": "扬声器 (Realtek(R) Audio)",
                "camera": "HD Camera",
                "audio": true,
                "video": true,
                "sharing": false,
                "join_time": "2022.12.23 11:16:59 (GMT+08:00)",
                "leave_time": "2022.12.23 11:18:51 (GMT+08:00)",
                "time_in_meeting": "00:01:52",
                "leave_reason": "主持人结束会议",
                "accept_status": 1,
                "is_external": false,
                "webinar_user_role": "0"
            }
        ],
        "page_token": "20",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ParticipantListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}