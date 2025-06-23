namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 创建会议室 请求体
/// <para>接口ID：7160517357592084483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "测试会议室",
    "capacity": 10,
    "description": "测试会议室描述",
    "custom_room_id": "1234",
    "room_level_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
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
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1RoomsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}