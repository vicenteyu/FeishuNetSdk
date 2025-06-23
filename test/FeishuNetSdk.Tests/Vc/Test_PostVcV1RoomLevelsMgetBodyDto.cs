namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 批量查询会议室层级详情 请求体
/// <para>接口ID：7160517356095897604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomLevelsMgetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "level_ids": [
        "omb_4ad1a2c7a2fbc5fc9570f38456931293"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1RoomLevelsMgetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}