namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 搜索会议室 请求体
/// <para>接口ID：7160517357591937027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostVcV1RoomsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "custom_room_ids": [
        "10001"
    ],
    "keyword": "测试会议室",
    "room_level_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
    "search_level_name": true,
    "page_size": 10,
    "page_token": "0"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1RoomsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}