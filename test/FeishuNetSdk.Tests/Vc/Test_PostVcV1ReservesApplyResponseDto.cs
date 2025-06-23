namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 预约会议 响应体
/// <para>接口ID：6960861158129008643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/apply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fapply</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ReservesApplyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reserve": {
            "id": "6911188411934973028",
            "meeting_no": "112000358",
            "password": "971024",
            "url": "https://vc.feishu.cn/j/337736498",
            "app_link": "https://applink.feishu.cn/client/videochat/open?source=openplatform&action=join&idtype=reservationid&id={?}&preview={?}&mic={?}&speaker={?}&camera={?}",
            "live_link": "https://meetings.feishu.cn/s/1gub381l4gglv",
            "end_time": "1608883322"
        },
        "reserve_correction_check_info": {
            "invalid_host_id_list": [
                "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1ReservesApplyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}