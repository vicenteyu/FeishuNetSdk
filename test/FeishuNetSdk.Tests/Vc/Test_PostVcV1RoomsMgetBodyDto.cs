namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 批量查询会议室详情 请求体
/// <para>接口ID：7160517356095946756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomsMgetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "room_ids": [
        "omm_32864aa53cad6fc3c866aeb0d15cd0cc"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1RoomsMgetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}