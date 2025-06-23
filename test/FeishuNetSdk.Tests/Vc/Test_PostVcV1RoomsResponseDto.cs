namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 创建会议室 响应体
/// <para>接口ID：7160517357592084483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "room": {
            "room_id": "omm_4de32cf10a4358788ff4e09e37ebbf9b",
            "name": "测试会议室",
            "capacity": 10,
            "description": "测试会议室描述",
            "display_id": "LM134742334",
            "custom_room_id": "1234",
            "room_level_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
            "path": [
                "omb_8d020b12fe49e82847c2af3c193d5754"
            ],
            "room_status": {
                "status": true,
                "schedule_status": true,
                "disable_start_time": "1652356050",
                "disable_end_time": "1652442450",
                "disable_reason": "测试占用",
                "contact_ids": [
                    "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
                ],
                "disable_notice": true,
                "resume_notice": true
            },
            "device": [
                {
                    "name": "电话"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1RoomsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}