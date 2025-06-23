namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 导出会议室预定数据 响应体
/// <para>接口ID：7124195547444510748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/resource_reservation_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fresource_reservation_list</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ExportsResourceReservationListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "7111325589855797267"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1ExportsResourceReservationListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}