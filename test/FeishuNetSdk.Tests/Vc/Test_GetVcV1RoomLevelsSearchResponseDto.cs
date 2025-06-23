namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 搜索会议室层级 响应体
/// <para>接口ID：7160517356095913988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fsearch</para>
/// </summary>
[TestClass]
public class Test_GetVcV1RoomLevelsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "level_ids": [
            "omb_4ad1a2c7a2fbc5fc9570f38456931293"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1RoomLevelsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}