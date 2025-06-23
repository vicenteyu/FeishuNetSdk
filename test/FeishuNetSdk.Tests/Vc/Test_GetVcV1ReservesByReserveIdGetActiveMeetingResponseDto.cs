namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取活跃会议 响应体
/// <para>接口ID：6921909217674952731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/get_active_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fget_active_meeting</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReservesByReserveIdGetActiveMeetingResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "meeting": {
            "id": "6911188411934433028",
            "topic": "my meeting",
            "url": "https://vc.feishu.cn/j/337736498",
            "meeting_no": "123456789",
            "password": "971024",
            "create_time": "1608885566",
            "start_time": "1608883322",
            "end_time": "1608888867",
            "host_user": {
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "user_type": 1
            },
            "meeting_connect": true,
            "status": 2,
            "participant_count": "10",
            "participant_count_accumulated": "10",
            "participants": [
                {
                    "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                    "first_join_time": "1624438144",
                    "final_leave_time": "1624438144",
                    "in_meeting_duration": "123",
                    "user_type": 1,
                    "is_host": true,
                    "is_cohost": false,
                    "is_external": false,
                    "status": 2
                }
            ],
            "ability": {
                "use_video": true,
                "use_audio": true,
                "use_share_screen": true,
                "use_follow_screen": true,
                "use_recording": true,
                "use_pstn": true
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReservesByReserveIdGetActiveMeetingResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}