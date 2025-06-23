namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 批量查询会议室层级详情 响应体
/// <para>接口ID：7160517356095897604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomLevelsMgetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "room_level_id": "层级ID",
                "name": "测试层级",
                "parent_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
                "path": [
                    "omb_4ad1a2c7a2fbc5fc9570f38456931293"
                ],
                "has_child": false,
                "custom_group_id": "10000"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1RoomLevelsMgetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}