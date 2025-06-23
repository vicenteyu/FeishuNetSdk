namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取 OKR 周期列表 响应体
/// <para>接口ID：6961663213280706561</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV1PeriodsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
                "en_name": "Jan - Mar 2022",
                "id": "7071200999834255380",
                "period_end_time": "1577721600000",
                "period_start_time": "1546272000000",
                "status": 0,
                "zh_name": "2022 年 1 月 - 3 月"
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV1PeriodsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}