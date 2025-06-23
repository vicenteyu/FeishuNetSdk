namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询会议室忙闲 响应体
/// <para>接口ID：6907569524100956161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/query-room-availability</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOyUjLygjM14iM4ITN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomFreebusyBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "time_max":"2019-09-04T09:45:00+08:00",
        "time_min":"2019-09-04T08:45:00+08:00",
        "free_busy":{
            "omm_83d09ad4f6896e02029a6a075f71c9d1":[
                {
                    "end_time":"2019-09-04T09:30:00+08:00",
                    "organizer_info": {
                        "name": "张三",
                        "open_id": "ou_09379914ab6dde664x9daf84d8b13842"
                    },
                    "start_time":"2019-09-04T09:00:00+08:00",
                    "original_time": 0,
                    "uid": "bff6b51f-b7c1-40c6-b8ef-aef966c9ffc7"
                }
            ],
            "omm_c7e9ef91ec9f3c007f1dfb2503918981": [
                {
                    "end_time": "2020-01-14T19:00:00+08:00",
                    "organizer_info": {
                        "name": "xxx",
                        "open_id": "ou_09379914ab6dde66499daf94d8b13842"
                    },
                    "original_time": 1578997800,
                    "start_time": "2020-01-14T18:30:00+08:00",
                    "uid": "5632b176-4f0e-44eb-8331-c4b155ed270f"
                }
           ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomFreebusyBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}