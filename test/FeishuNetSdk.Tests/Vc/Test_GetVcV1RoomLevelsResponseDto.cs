namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询会议室层级列表 响应体
/// <para>接口ID：7160517357592117251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2flist</para>
/// </summary>
[TestClass]
public class Test_GetVcV1RoomLevelsResponseDto : TestBase
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
        ],
        "page_token": "10",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1RoomLevelsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}